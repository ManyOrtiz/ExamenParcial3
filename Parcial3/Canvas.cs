﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using System.Windows.Forms;

namespace Parcial3
{
    public class Canvas
    {
        public Bitmap bitmap;
        public float Width, Height;
        private byte[] bits;
        private int pixelFormatSize, stride;
        public float scale = 1f;
        public int power = -20;

        public Color color;

        public Canvas(Size size)
        {
            Init(size.Width, size.Height);
        }

        private void Init(int width, int height)
        {
            // Crear un generador de números aleatorios
            Random random = new Random();

            // Generar valores aleatorios para los componentes rojo, verde y azul
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            // Establecer el color
            color = Color.FromArgb(red, green, blue);
            PixelFormat format = PixelFormat.Format32bppArgb;
            bitmap = new Bitmap(width, height, format);
            Width = width;
            Height = height;
            pixelFormatSize = Image.GetPixelFormatSize(format) / 8;
            stride = width * pixelFormatSize;
            bits = new byte[stride * height];
            var handle = GCHandle.Alloc(bits, GCHandleType.Pinned);
            IntPtr bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bits, 0);
            bitmap = new Bitmap(width, height, stride, format, bitPtr);

        }

        public void FastClear()
        {
            unsafe
            {
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadWrite, bitmap.PixelFormat);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(bitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        currentLine[x] = 0; // Blue
                        currentLine[x + 1] = 0; // Green
                        currentLine[x + 2] = 0; // Red
                        currentLine[x + 3] = 0; // Alpha
                    }
                });

                bitmap.UnlockBits(bitmapData);
            }
        }

        public void Render(Scene scene, Matrix4x4 rotationMatrix)
        {
            FastClear();
            scene.Render(this, rotationMatrix, power, color);
        }

        public void DrawShadedTriangle(Point p1, Point p2, Point p3, Color color, float h1, float h2, float h3)
        {
            // Ordenar los puntos por y
            if (p1.Y > p2.Y) { Swap(ref p1, ref p2); Swap(ref h1, ref h2); }
            if (p1.Y > p3.Y) { Swap(ref p1, ref p3); Swap(ref h1, ref h3); }
            if (p2.Y > p3.Y) { Swap(ref p2, ref p3); Swap(ref h2, ref h3); }

            // Dibujar el triángulo relleno con sombreado
            int totalHeight = p3.Y - p1.Y;
            for (int y = 0; y <= totalHeight; y++)
            {
                bool secondHalf = y > p2.Y - p1.Y || p2.Y == p1.Y;
                int segmentHeight = secondHalf ? p3.Y - p2.Y : p2.Y - p1.Y;
                float alpha = (float)y / totalHeight;
                float beta = (float)(y - (secondHalf ? p2.Y - p1.Y : 0)) / segmentHeight; // Evitar la división por cero

                Point A = Interpolate(p1, p3, alpha);
                Point B = secondHalf ? Interpolate(p2, p3, beta) : Interpolate(p1, p2, beta);
                float hA = Interpolate(h1, h3, alpha);
                float hB = secondHalf ? Interpolate(h2, h3, beta) : Interpolate(h1, h2, beta);

                if (A.X > B.X)
                {
                    Swap(ref A, ref B);
                    Swap(ref hA, ref hB);
                }

                for (int x = A.X; x <= B.X; x++)
                {
                    float phi = B.X == A.X ? 1.0f : (float)(x - A.X) / (B.X - A.X);
                    float h = Interpolate(hA, hB, phi);

                    Color shadedColor = Shade(color, h);
                    SetPixel(x, p1.Y + y, shadedColor);
                }
            }
        }

        private Point Interpolate(Point p1, Point p2, float gradient)
        {
            int x = (int)(p1.X + (p2.X - p1.X) * gradient);
            int y = (int)(p1.Y + (p2.Y - p1.Y) * gradient);
            return new Point(x, y);
        }

        private float Interpolate(float min, float max, float gradient)
        {
            return min + (max - min) * gradient;
        }

        private void Swap(ref Point p1, ref Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }

        private void Swap(ref float h1, ref float h2)
        {
            float temp = h1;
            h1 = h2;
            h2 = temp;
        }

        private Color Shade(Color color, float intensity)
        {
            intensity = Clamp(intensity, 0f, 1f);
            int red = (int)(color.R * intensity);
            int green = (int)(color.G * intensity);
            int blue = (int)(color.B * intensity);
            return Color.FromArgb(Clamp(red, 0, 255), Clamp(green, 0, 255), Clamp(blue, 0, 255));
        }

        private void SetPixel(int x, int y, Color color)
        {
            // Primero, valida que x e y estén dentro de los límites del canvas.
            if (x < 0 || x >= Width || y < 0 || y >= Height) return;

            // Calcula el índice dentro del arreglo de bytes.
            int index = (y * stride) + (x * pixelFormatSize);

            // Verifica que el índice calculado más el tamaño de un píxel no exceda los límites del arreglo.
            if (index < 0 || (index + 3) >= bits.Length) return;

            // Ahora es seguro establecer los valores de color en el arreglo de bytes.
            bits[index + 0] = color.B;
            bits[index + 1] = color.G;
            bits[index + 2] = color.R;
            bits[index + 3] = color.A;
        }


        private float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
}
