using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_1
{
    class Program
    {

       

        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество элементов: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ведите {0} элемент: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int value in a)
            {
                sum += value;
            }         
            double min, max;
            min = a[0];
            max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            double sr = 0;
            for (int i = 0; i < n; i++)
            sr = (sum - (min + max))/(n - 2);
            Console.WriteLine("Среднее арифметическое = {0}", sr);
            Console.WriteLine("Минимальный элемент: {0}", min);
            Console.WriteLine("Максимальный элемент: {0}", max);
            Console.ReadKey();
        }
    }
}
    

