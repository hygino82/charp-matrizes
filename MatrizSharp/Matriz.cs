using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizSharp
{
    class Matriz
    {
        public static void EscrevaMatriz(double[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            Console.WriteLine("A matriz possui dimensões" + linha + " x " + coluna);
        }
    }
}
