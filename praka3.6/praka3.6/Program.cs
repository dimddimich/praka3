using System;
using System.Drawing;

namespace praka3_6
{
    class programma
    {
        static void Main()
        {
            Console.WriteLine("Введите длину");
            int lenght = Convert.ToInt32(Console.ReadLine());
            MyintList list = new MyintList(lenght);




        }
    }
    class MyintList
    {
        public MyintList(int lenght)
        {
            int[] result = new int[lenght];
            Random random = new Random();
            int sum = 0;
            int middleIndex = result.Length / 2;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(20);
                sum += result[i] * result[i];
                Console.WriteLine(i + 1 + ": " + result[i]);
            }


            int dispersia = Convert.ToInt32(sum) / result.Length;
            int sko = dispersia / result.Length;
            Console.WriteLine("Дисперсия: " + dispersia);
            Console.WriteLine("СКО: " + sko);
            double mediana;
            if (result.Length % 2 == 0)
            {
                mediana = (result[middleIndex - 1] + result[middleIndex]) / 2.0;
            }
            else
            {
                mediana = result[middleIndex];
            }
            Console.WriteLine("Медиана: " + mediana);

        }

    }


}
