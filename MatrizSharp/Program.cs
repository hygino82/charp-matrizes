using System;

namespace MatrizSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double[,] m = new double[,] { { 3, 1 }, { 8, 7 }, { 9, 5 } };

            Matriz.EscrevaMatriz(m);
        }
    }
}
