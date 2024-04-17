using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Numerics;
namespace Parcial3
{
    public class Model
    {
        public List<Mesh> Meshes { get; set; } = new List<Mesh>();

        public Model(string path)
        {
            LoadModel(path);
            CenterModel();
        }

        private void LoadModel(string path)
        {
            Mesh mesh = new Mesh();
            foreach (var line in File.ReadAllLines(path))
            {
                if (line.StartsWith("v "))
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    mesh.Vertices.Add(new Vector3(
                        float.Parse(parts[1], CultureInfo.InvariantCulture),
                        float.Parse(parts[2], CultureInfo.InvariantCulture),
                        float.Parse(parts[3], CultureInfo.InvariantCulture)));
                }
                else if (line.StartsWith("f"))
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    mesh.Indexes.Add(new int[] {
                    int.Parse(parts[1].Split('/')[0]) - 1,
                    int.Parse(parts[2].Split('/')[0]) - 1,
                    int.Parse(parts[3].Split('/')[0]) - 1
                });
                }
            }
            Meshes.Add(mesh);
        }
        private void CenterModel()
        {
            // Calcular el centro del modelo
            Vector3 center = CalculateCenter();

            // Calcular la traslación necesaria para centrar el modelo
            Vector3 translation = new Vector3(-center.X, -center.Y, -center.Z);

            // Aplicar la traslación a todos los vértices del modelo
            foreach (var mesh in Meshes)
            {
                for (int i = 0; i < mesh.Vertices.Count; i++)
                {
                    mesh.Vertices[i] += translation;
                }
            }
        }

        private Vector3 CalculateCenter()
        {
            Vector3 sum = Vector3.Zero;
            int count = 0;

            // Calcular la suma de todas las coordenadas de los vértices
            foreach (var mesh in Meshes)
            {
                foreach (var vertex in mesh.Vertices)
                {
                    sum += vertex;
                    count++;
                }
            }

            // Calcular el centro como el promedio de todas las coordenadas
            return sum / count;
        }
    }
}
