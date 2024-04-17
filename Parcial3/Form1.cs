using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3//el perron
{
    public partial class Form1 : Form
    {
        private Canvas canvas;
        private Scene scene;
        private float angle = 0;
        private int caso = 0;
        private Matrix4x4 matrix;
        private bool isModelLoaded = true;
        private bool isRotationPaused = false;
        private bool rotateX = false;
        private bool rotateY = false;
        private bool rotateZ = false;
        private float rotationSpeed = 0.03f;

        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(pictureBox1.Size);
            scene = new Scene(canvas);
            timer1.Tick += timer1_Tick;
            timer1.Start();


            pictureBox1.ClientSizeChanged += PictureBox1_ClientSizeChanged;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += rotationSpeed;
            if (isModelLoaded && !isRotationPaused)
            {
                matrix = Matrix4x4.Identity;

                if (rotateX == true)
                {
                    matrix *= Matrix4x4.CreateRotationY(angle);

                }

                if (rotateY == true)
                {
                    matrix *= Matrix4x4.CreateRotationX(angle);
                }

                if (rotateZ == true)
                {
                    matrix *= Matrix4x4.CreateRotationZ(angle);
                }
            }
            RenderScene();
        }
        private void STOP_BTN_Click_1(object sender, EventArgs e)
        {
            isRotationPaused = !isRotationPaused;
            if (isRotationPaused == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void ButtonX_Click_1(object sender, EventArgs e)
        {
            rotateX = !rotateX;
        }

        private void ButtonY_Click_1(object sender, EventArgs e)
        {
            rotateY = !rotateY;
        }

        private void ButtonZ_Click_1(object sender, EventArgs e)
        {
            rotateZ = !rotateZ;
        }
        private void PictureBox1_ClientSizeChanged(object sender, EventArgs e)
        {

            if (pictureBox1.ClientSize.Width > 0 && pictureBox1.ClientSize.Height > 0 && scene != null)
            {
                canvas = new Canvas(pictureBox1.ClientSize);
                RenderScene();
            }

        }
        private void RenderScene()
        {

            canvas.Render(scene, matrix);
            pictureBox1.Image = canvas.bitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            canvas.scale = (float)trackBar1.Value / 200;
        }

        private void OBJ_LOAD_Click_1(object sender, EventArgs e)
        {
            string ruta = textBox1.Text;

            // Verificar si la ruta no está vacía
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                try
                {
                    // Intentar agregar el modelo a la escena
                    scene.Models.Add(new Model(ruta));
                    isModelLoaded = true;
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra al agregar el modelo
                    MessageBox.Show("Error al agregar el modelo: " + ex.Message);
                }
            }
            else
            {
                isModelLoaded = false;
            }
        }

        private void LIGHT_BTN_Click_1(object sender, EventArgs e)
        {
            // Obtener el valor de la intensidad de iluminación del TextBox
            if (int.TryParse(textBox2.Text, out int intensity))
            {
                // Actualizar la intensidad de iluminación en el canvas
                canvas.power = intensity;
            }
            else
            {
                // Manejar el caso en que la entrada del usuario no sea un número válido
                MessageBox.Show("Por favor, ingrese un número válido para la intensidad de iluminación.");
            }
        }

        private void VEL_BTN_Click_1(object sender, EventArgs e)
        {
            /*
            if (float.TryParse(textBox3.Text, out float newSpeed))
            {
                // Actualizar la velocidad de rotación
                rotationSpeed = newSpeed;
            }
            else
            {
                // Manejar el caso en que la entrada del usuario no sea un número válido
                MessageBox.Show("Por favor, ingrese un número válido para la velocidad de rotación.");
            }
            */
            /*
            if (float.TryParse(textBox3.Text, out float userInputSpeed))
            {
                // Normalizar la entrada del usuario al rango [-5, 5]
                float normalizedSpeed = Math.Min(Math.Max(userInputSpeed, -5), 5);

                // Mapear la velocidad normalizada al rango de velocidad real que deseas
                rotationSpeed = normalizedSpeed * 0.03f; // 0.03 es un factor de escala para ajustar la velocidad real
            }
            else
            {
                // Manejar el caso en que la entrada del usuario no sea un número válido
                MessageBox.Show("Por favor, ingrese un número válido para la velocidad de rotación.");
            }
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Generar valores aleatorios para los componentes R, G y B
            Random rnd = new Random();
            int red = rnd.Next(0, 256); // Valor entre 0 y 255
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            // Construir un color con los valores aleatorios
            Color randomColor = Color.FromArgb(red, green, blue);

            // Asignar el color aleatorio a canvas.color
            canvas.color = randomColor;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            canvas.scale = (float)trackBar1.Value / 200;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RESET_BTN_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
