using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[100];
                int n, i;
                Console.Write("Введите n: ");
                n = int.Parse(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }
            }
            catch (Exception ex)    
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}