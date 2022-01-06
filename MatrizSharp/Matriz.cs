using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizSharp
{
    class Matriz
    {
        public static void Escreva(double[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            Console.WriteLine("A matriz possui dimensões " + linha + " x " + coluna);

            for (int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] Copia(double[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            double[,] copia = new double[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    copia[i, j] = matriz[i, j];
                }
            }

            return copia;
        }

        public static double[,] Transposta(double[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            double[,] transposta = new double[coluna, linha];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            return transposta;
        }

    }
}
