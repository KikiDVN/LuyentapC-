using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hay nhap n cac ban nhe: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri thu " + i + " la: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max) { max = arr[i];}
                if (max < arr[i]) { min = arr[i];}
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Max la: " + max);
            Console.WriteLine("Min la: "+ min);
            Console.ReadKey();
        }
    }
}
