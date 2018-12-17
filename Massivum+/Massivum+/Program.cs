using System;

namespace Massivum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массивов");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массивов");
            int a = int.Parse(Console.ReadLine());

            int[,] m1 = new int[a, b];
            Console.WriteLine("Заполните данные для первого массива");
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    Console.Write("mas[" + k + "," + l + "]: ");

                    m1[k, l] = int.Parse(Console.ReadLine());
                }
            }

            int[,] m2 = new int[a, b];
            Console.WriteLine("Заполните данные для второго массива");
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    Console.Write("mas[" + k + "," + l + "]: ");
                    m2[k, l] = int.Parse(Console.ReadLine());
                }
            }

            int[,] msum = new int[a, b];
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    msum[k, l] = m1[k, l] + m2[k, l];
                }
            }

            Console.WriteLine("Итоговый массив");
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    Console.Write(msum[k, l] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}
