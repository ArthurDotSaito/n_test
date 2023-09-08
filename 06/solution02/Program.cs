using System;
using System.IO;
using System.Text;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "matrix.txt";
            int n = 3;
            CreateMatrix(filename, n);
            Console.WriteLine($"Matriz {n}x{n} gerada e salva em '{filename}'.");

            int[,] matrix = ReadMatrix(filename);
            Console.WriteLine("Original: ");
            ShowMatrix(matrix);
            int[,] invertedMatrix = InvertMatrixDiagonals(matrix);
            Console.WriteLine("Diagonals Inverted: ");
            ShowMatrix(invertedMatrix);
        }
        static void CreateMatrix(string filename, int n)
        {
            Random r = new Random();
            FileStream f = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            sw.Write($"{n} {n}\r\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; ++j)
                {
                    int element = r.Next(11);
                    sw.Write($"{element} ");
                }
                sw.Write("\r\n");
            }
            sw.Close();
            f.Close();
        }
        static int[,] ReadMatrix(string filename)
        {
            FileStream f = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string[] dimension = sr.ReadLine().Split(' ');
            int size = int.Parse(dimension[0]);
            int[,] ret = new int[size, size];

            for (int i = 0; i < size; ++i)
            {
                string line = sr.ReadLine();
                string[] elements = line.Split(' ');

                for (int j = 0; j < size; ++j)
                {
                    ret[i, j] = int.Parse(elements[j]);
                }
            }
            sr.Close();
            return ret;
        }

        static void ShowMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] InvertMatrixDiagonals(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[,] invertedMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                invertedMatrix[i, i] = matrix[i, size - i - 1];
                invertedMatrix[i, size - i - 1] = matrix[i, i];
            }
            return invertedMatrix;
        }
    }
}