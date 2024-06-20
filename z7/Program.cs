using System;
using System.Linq;

class Program
{
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }

    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);

        Console.WriteLine("Объединенный массив:");
        foreach (int num in mergedArray)
        {
            Console.Write(num + " ");
        }
    }
}
