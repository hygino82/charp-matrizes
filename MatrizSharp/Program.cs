using System;

namespace MatrizSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz informada");
            double[,] m = new double[,] { { 3, 1 }, { 8, 7 }, { 9, 5 } };
            Matriz.Escreva(m);

            Console.WriteLine("Matriz transposta");
            double[,] t = Matriz.Transposta(m);
            Matriz.Escreva(t);

        }
    }
}
