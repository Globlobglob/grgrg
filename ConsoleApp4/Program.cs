using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Pazmer mass = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int [n];
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int p = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += p;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            Console.ReadKey();*/

            /*
            int[] array = { 7, -1, 2, -4, 8, -3 };
            int count = 0;
            foreach(int elem in array)
            {
                if (elem % 2 == 0) count++;
            }
            Console.WriteLine($"count={count}");
            */
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.WriteLine($"ARRAY[{i}]={array[i]}");
            }
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                
            }                

        }
    }
}
