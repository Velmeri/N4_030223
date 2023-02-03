using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4_030223
{
    static class Task
    {
        static private readonly Random random = new Random();
        static private void PrintArr(int[][] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{");
                foreach (int a in arr[i]) Console.Write($"{a} ");
                Console.Write("}\n");
            }
        }
        static public void N1()
        {
            int[][] arr = new int[5][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[random.Next(5)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(100);
                }
            }

            PrintArr(arr);
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length < arr[minIndex].Length) minIndex = i;
                if (arr[i].Length > arr[maxIndex].Length) maxIndex = i;
            }
            (arr[minIndex], arr[maxIndex]) = (arr[maxIndex], arr[minIndex]);
            Console.WriteLine();
            PrintArr(arr);
        }
        static public void N2()
        {
            int height = 4;
            int length = 6;
            if (length < height) (height, length) = (length, height);
            int[][] arr = new int[height][];
            for (int i = 0; i < arr.Length; i++) arr[i] = new int[length-i];
            PrintArr(arr);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N1:");
            Task.N1();
            Console.WriteLine("\n\nN2:");
            Task.N2();
            Console.ReadKey();
        }
    }
}
