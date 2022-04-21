using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_or_min_with_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            int max, min;
          
            Console.Write("Enter The Array Size : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("My Array Size {0} ",size);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Element of array {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < size; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }


            Console.WriteLine("Maximum number" + max);
            Console.WriteLine("Manimum number" + min);
            Console.ReadLine();
        }
    }
}
