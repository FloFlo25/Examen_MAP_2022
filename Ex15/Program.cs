using System;
using System.Collections.Generic;
using System.IO;

namespace Ex15
{
    public class Program
    {
        public const string InputFilePath = @"../../data.in";
        public const string OutputFilePath = @"../../data.out";

        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllLines(InputFilePath)[0].Split(' ')[0]), x=0;//4   12
            int m = int.Parse(File.ReadAllLines(InputFilePath)[0].Split(' ')[1]);//5
            int j = 0;
            int[,] A = new int[101, 101];

            List<string> lines = new List<string>(File.ReadAllLines(InputFilePath));

            bool found = false;
            bool ok = false;

            foreach (var line in lines)
            {
                if (!ok)
                {
                    ok = true;
                    continue;
                }

                if (j == n)
                {
                    x = int.Parse(line.Split(' ')[0]);
                    break;
                }

                for (int i = 0; i < m; i++)
                {
                    A[j, i] = int.Parse(line.Split(' ')[i]);
                }
                j++;
            }




            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    if (i==1 || i==n || j==1 || j==m && A[i,j]==x)
                    {
                        found = true;
                    }
                }

            }


            if (found)
            {
                File.WriteAllText(OutputFilePath, "DA");
            }
            else
            {
                File.WriteAllText(OutputFilePath, "NU");
            }

        }
    }
}
