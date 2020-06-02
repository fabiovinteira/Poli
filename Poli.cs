using System;
namespace Poli
{
    public static class Circ
    {
        public static double Area(double raio)
        {
            return Math.PI * Math.Pow(2*raio, 2);
        }

        public static double Perimetro(double raio)
        {
            return Math.PI * (2 * raio);
        }

        public static double Diametro(double raio)
        {
            return raio * 2;
        }
    }

    public class Quad
    {
        public static double Area(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double Perimetro(double lado)
        {
            return lado * 4;
        }

        public static double Diag(double lado)
        {
            return Math.Sqrt(Math.Pow(lado, 2) + Math.Pow(lado, 2));
        }
    }

    public class Ret
    {
        public static double Area(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Perimetro(double n1, double n2)
        {
            return 2 * n1 + 2 * n2;
        }

        public static double Diag(double n1, double n2)
        {
            return Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
        }
    }
}
