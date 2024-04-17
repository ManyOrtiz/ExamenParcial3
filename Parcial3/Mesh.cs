using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3
{
    public class Mesh
    {
        public List<Vector3> Vertices { get; set; } = new List<Vector3>();
        public List<int[]> Indexes { get; set; } = new List<int[]>();

        private List<Light> meshLight = new List<Light>();

        public class Light
        {
            public Vector3 Direction { get; set; }
            public Color Color { get; set; }

            public Light(Vector3 direction, Color color)
            {
                Direction = direction;
                Color = color;
            }
        }

        public Mesh()
        {
            // Luz desde la derecha
            meshLight.Add(new Light(new Vector3(3, 2, 0), Color.Yellow));
            meshLight.Add(new Light(new Vector3(3, 1, 0), Color.Yellow));
            meshLight.Add(new Light(new Vector3(3, 0, 0), Color.Yellow));
            meshLight.Add(new Light(new Vector3(2, 0, 0), Color.Yellow));
            meshLight.Add(new Light(new Vector3(1, 0, 0), Color.Yellow));// Luz desde arriba
        }



        public void Render(Canvas canvas, Matrix4x4 rotationMatrix, int power, Color color)
        {
            Vector3 cameraDirection = new Vector3(0, 0, -1); // Asumiendo que la cámara mira hacia el -Z

            for (int faceIndex = 0; faceIndex < Indexes.Count; faceIndex++)
            {
                var face = Indexes[faceIndex];
                if (face.Length < 3) continue; // Necesitamos al menos 3 vértices para un triángulo

                Vector3[] worldVertices = new Vector3[3];
                Vector2[] screenVertices = new Vector2[3];
                float[] intensities = new float[3];

                // Transformar vértices al espacio de la pantalla y calcular intensidades
                for (int i = 0; i < 3; i++)
                {
                    worldVertices[i] = Vector3.Transform(Vertices[face[i]], rotationMatrix);
                    screenVertices[i] = new Vector2(
                        (worldVertices[i].X * canvas.scale * canvas.Height + canvas.Width * 0.5f),
                        ((1 - worldVertices[i].Y * canvas.scale) * canvas.Height - canvas.Height * 0.5f));
                    //intensities[i] = CalculateLightIntensity2(worldVertices[i], canvas);
                    intensities[i] = CalculateLightIntensityM(worldVertices[i], canvas, power);
                }

                // Calcular la normal del triángulo
                Vector3 v1 = worldVertices[1] - worldVertices[0];
                Vector3 v2 = worldVertices[2] - worldVertices[0];
                Vector3 normal = Vector3.Cross(v1, v2);
                normal = Vector3.Normalize(normal);

                // Verificar si el triángulo está frente a la cámara
                if (Vector3.Dot(normal, cameraDirection) < 0)
                {
                    // El triángulo está frente a la cámara; renderizarlo
                    canvas.DrawShadedTriangle(
                        new Point((int)screenVertices[0].X, (int)screenVertices[0].Y),
                        new Point((int)screenVertices[1].X, (int)screenVertices[1].Y),
                        new Point((int)screenVertices[2].X, (int)screenVertices[2].Y),
                        color, intensities[0], intensities[1], intensities[2]);
                }
            }

        }

        private float CalculateLightIntensityM(Vector3 point, Canvas canvas, int power)
        {
            float maxDistance = (float)Math.Sqrt(Math.Pow(10, 2) + Math.Pow(10, 2));

            float totalIntensity = 0f;

            for (int i = 0; i < meshLight.Count; i++)
            {
                // Calculate the distance from the point to the center
                float distance = Vector3.Distance(point, meshLight[i].Direction);

                // Use an exponential function to calculate the intensity based on distance
                // You can adjust the factor (-30) for the intensity falloff according to your needs
                float intensity = (float)Math.Exp(power * (distance / maxDistance));

                // Sum up intensities from all points
                totalIntensity += intensity;
            }

            return totalIntensity;
        }
    }
}
