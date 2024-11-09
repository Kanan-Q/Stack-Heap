namespace StackHeap;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] arr1 = { 9, 5, 3 };
        WriteLine("Kohne Array:");
        OldArray(arr1);

        int[] arr2 = NewArray(arr1, 4, 7, 8);
        WriteLine("\nYeni Array:");
        OldArray(arr2);
    }

    static int[] NewArray(int[] arr1, params int[] arr2)
    {
        int Size = arr1.Length + arr2.Length;
        int[] newArray = new int[Size];

        for (int i = 0; i < arr1.Length; i++)
        {
            newArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            newArray[arr1.Length + i] = arr2[i];
        }

        return newArray;
    }

    static void OldArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Write(arr[i]);
        }
    }
}

