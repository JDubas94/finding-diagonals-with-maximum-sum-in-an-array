using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[,] newArray = new int[4,5]
            {
            {2, 5, 4, 1, 8},
            {10, 3, 1, 2, 6},
            {3, 5, 8, 2, 1 },
            {4, 3, 1, 9, 7 },
            };

            int y = newArray.GetLength(0);
            int x = newArray.GetLength(1);

            int sum = 0;
            int diagonlSum = 0;

            for (int i = 0; i < y ; i++) 
            {
                diagonlSum = 0;
                for (int n = 0; n <= i; n++)
                {
                   Console.WriteLine(newArray[n, i - n]);
                    diagonlSum += newArray[n, i - n];

                }
                Console.WriteLine("Сумма диагоналей" + diagonlSum);
                if (diagonlSum > sum)
                {
                    sum = diagonlSum;
                }
               
                Console.WriteLine();
               
            }
            for (int m = 0; m < y; m++)
            {
                diagonlSum = 0;
                for (int j = y-1; j >= m; j--)
                {
                Console.WriteLine(newArray[j,y-j+m]);
                    diagonlSum += newArray[j,y-j+m];
                }
                Console.WriteLine("Сумма диагоналей" + diagonlSum);
                if (diagonlSum > sum)
                {
                    sum = diagonlSum;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Найбольшая сумма диагоналей" + sum);
            for (int k = 0; k < 4; k++)
            {
                diagonlSum = 0;
                for (int z = 0; z < y - k; z++)
                {
                    Console.WriteLine(newArray[z, z + k + 1]);
                    diagonlSum += newArray[z, z + k + 1];
                }
                if (diagonlSum > sum)
                {
                    sum = diagonlSum;
                }

                Console.WriteLine("Сумма диагоналей" + diagonlSum);
                Console.WriteLine();
            }
            for (int k = 2; k <= 4; k++)
            {
                diagonlSum = 0;
                for (int t = 0; t <= x - k; t++)
                {
                    Console.WriteLine(newArray[t + k - 2, t]);
                    diagonlSum += newArray[t + k - 2, t];
                }
                if (diagonlSum > sum)
                {
                    sum = diagonlSum;
                }

                Console.WriteLine("Сумма диагоналей" + diagonlSum);
                Console.WriteLine();
            }








        }

    }
}
