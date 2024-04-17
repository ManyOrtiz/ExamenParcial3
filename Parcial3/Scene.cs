using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Parcial3
{
    public class Scene
    {
        public List<Model> Models { get; set; } = new List<Model>();
        private Canvas canvas;


        public Scene(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void Render(Canvas canvas, Matrix4x4 rotationMatrix, int power, Color color)
        {
            if (canvas.Width <= 0 || canvas.Height <= 0)
            {
                return;
            }

            foreach (var model in Models)
            {
                foreach (var mesh in model.Meshes)
                {
                    mesh.Render(canvas, rotationMatrix, power, color); // Renderiza cada malla en el Canvas
                }
            }
        }
    }
}
