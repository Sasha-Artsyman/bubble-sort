using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort 
{
    class Program
    {
        static void Main (string[] args)
        {
            // new array
            int[] arr = new int [100]; 
            Fill(arr);
            Console.WriteLine("Haven't sorted array:\n");
            // printing initial array
            Print(arr);
            Console.WriteLine("\n-------------------------\n");
            // sorting
            BubbleSort(arr);
            Console.WriteLine("Sorted array:\n");
            // printing sorted array
            Print(arr);
        }
        // swap
        public static void Swap<T>(ref T variable1, ref T variable2)
        {
            T temp  = variable1;
            variable1 = variable2;
            variable2 = temp;
        } 
        static void BubbleSort(int[] arr)
        {
            int size = arr.Length - 1;
            bool swapped;
            for(int i = 0; i < size; i++)
            {
                 swapped = false;
                 for(int j = 0; j < size - i; j++)
                 {
                      if(arr[j] > arr[j+1]) 
                      {
                           Swap(ref arr[j], ref arr[j+1]);
                           swapped = true;
                      }
                 }
                 if(!swapped) break;
            }
        }
        static void Fill(int[] arr, int minValue = 1, int maxValue = 1000)
        {
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
                  arr[i] = rnd.Next(minValue, maxValue);
        }
        static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
                  Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
    }
}
