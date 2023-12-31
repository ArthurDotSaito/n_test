﻿using System;
using System.IO;
namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaMatriz("A.txt", 10, 10);
            CriaMatriz("B.txt", 3, 3);
            int[,] A = LerMatriz("A.txt");
            int[,] B = LerMatriz("B.txt");
            Console.WriteLine(NumeroDeOcorrencias(A, B));
        }
        static int NumeroDeOcorrencias(int[,] matriz, int[,] padrao)
        {
            int N = matriz.GetLength(0), M = matriz.GetLength(1);
            int n = padrao.GetLength(0), m = padrao.GetLength(1);
            int contador = 0;

            for (int i = 0; i <= N - n; i++)
            {
                for (int j = 0; j <= M - m; j++)
                {
                    if (VerificarPadrao(matriz, padrao, i, j)) contador++;
                }
            }
            return contador;
        }

        static bool VerificarPadrao(int[,] matriz, int[,] padrao, int x, int y)
        {
            int n = padrao.GetLength(0);
            int m = padrao.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[x + i, y + j] != padrao[i, j]) return false;
                }
            }
            return true;
        }
        static int[,] LerMatriz(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string[] tamanho = sr.ReadLine().Split(' ');
            int n = int.Parse(tamanho[0]);
            int m = int.Parse(tamanho[1]);
            int[,] ret = new int[n, m];

            for (int i = 0; i < n; ++i)
            {
                string linha = sr.ReadLine();
                for (int j = 0; j < m; ++j)
                {
                    ret[i, j] = linha[j] == '0' ? 0 : 1;
                }
            }
            sr.Close();
            return ret;
        }
        static void CriaMatriz(string fileName, int n, int m)
        {
            Random r = new Random();
            FileStream f = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            sw.Write($"{n} {m}\r\n");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    sw.Write(r.Next(2) == 0 ? '0' : '1');
                }
                sw.Write("\r\n");
            }
            sw.Close();
            f.Close();
        }
    }
}
