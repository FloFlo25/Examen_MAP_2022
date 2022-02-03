using System;
using System.IO;

namespace Ex14
{
    internal class Program
    {
        public static string InputFilePath = @"../../data.in";
        public static string OutputFilePath = @"../../data.out";
        public static int n = int.Parse(File.ReadAllText(InputFilePath));
        public static int[] x = new int[10];

        static void Show(int n)
        {
            for (int i = 1; i <= n; ++i)
            {
                File.AppendAllText(OutputFilePath, $"{i} ");
            }
            File.AppendAllText(OutputFilePath, "\n");
        }

        static void Backtracking(int k)
        {
            for (int i = x[k - 1] + 1; i <= n; ++i)
            {
                x[k] = i;
                Show(k);
                Backtracking(k + 1);
            }
        }


        static void Main(string[] args)
        {
            File.WriteAllText(OutputFilePath, "");

            Backtracking(1);
        }
    }
}
