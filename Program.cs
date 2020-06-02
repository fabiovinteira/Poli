using System;
using System.Globalization;

namespace Poligonos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.Write("Digite o raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            Console.WriteLine("Para um Circulo de raio: " + raio.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + Poli.Circ.Area(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + Poli.Circ.Perimetro(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diametro: " + Poli.Circ.Diametro(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            Console.Write("Digite o lado de um quadrado: ");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            Console.WriteLine("Para um Quadrado de lado: " + lado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + Poli.Quad.Area(lado).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + Poli.Quad.Perimetro(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + Poli.Quad.Diag(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            Console.Write("Digite os lados de um retangulo (2): ");
            string[] lr = Console.ReadLine().Split(' ');
            double l1 = double.Parse(lr[0]);
            double l2 = double.Parse(lr[1]);

            Console.WriteLine("------------------------");

            Console.WriteLine("Para um Retangulo de lados: " + l1.ToString("F2", CultureInfo.InvariantCulture) + " e " + l2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + Poli.Ret.Area(l1, l2).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + Poli.Ret.Perimetro(l1, l2).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + Poli.Ret.Diag(l1, l2).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
