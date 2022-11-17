int findIndex(int[] a, int n)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == n)
        {
            return i;
        }
    }
    return -1;
}


int[] arr = { 15, 432, 32, 8, 91, 33, 41, 00, 32 };

int number = int.Parse(Console.ReadLine());

Console.WriteLine(findIndex(arr, number));