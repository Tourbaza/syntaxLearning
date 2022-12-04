using System.Xml.Linq;

namespace SyntaxLearning
{
    class Program
    {
        //add element by index
        static void Insert<T>(ref T[] arr, T element, int index)
        {
            T[] newArr = new T[arr.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[index] = element;

            for (int i = index; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            arr = newArr;
        }

        //add element in beginning of array
        static void AddFirst<T>(ref T[] arr, T element)
        {
            Insert(ref arr, element, 0);
        }

        //add element in end of array
        static void AddLast<T>(ref T[] arr, T element)
        {
            Insert(ref arr, element, arr.Length);
        }

        //change length of array
        static void Resize<T>(ref T[] arr, int arrSize)
        {
            T[] newArr = new T[arrSize];

            for(int i = 0; i < Math.Min(arrSize, arr.Length); i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

        //find index of first entry of element
        static int FindIndex(int[] arr, int element)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == element)
                {
                    return index;
                }
            }
            return -1;
        }

        //remove element at index
        static void RemoveAt<T>(ref T[] arr, int index)
        {
            T[] newArr = new T[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = index; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }

            arr = newArr;
        }

        //remove element at beginning of array
        static void RemoveFirst<T>(ref T[] arr)
        {
            RemoveAt(ref arr, 0);
        }

        //remove element at end of array
        static void RemoveLast<T>(ref T[] arr)
        {
            RemoveAt(ref arr, arr.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] array = {1, 23, 51};

            Resize(ref array, 5);

            Insert(ref array, 27, 2);
            AddFirst(ref array, 0);
            AddLast(ref array, 99);

            RemoveAt(ref array, 3);
            RemoveFirst(ref array);
            RemoveLast(ref array);

            for (int i = 0; i <  array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}