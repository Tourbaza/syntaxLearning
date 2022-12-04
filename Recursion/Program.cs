//Array output
void Print(int[] arr, int i = 0)
{
    if (i < arr.Length)
    {
        Console.WriteLine(arr[i]);
        Print(arr, i + 1);
    }
}

//Sum of array elements
int Sum(int[] arr, int i = 0)
{
    if (i >= arr.Length)
        return 0;

    return arr[i] + Sum(arr, i + 1);
}

//Sum digits of number
int SumOfDigits(int num)
{
    if (num < 10)
        return num;

    return num % 10 + SumOfDigits(num / 10);
}


int[] array = { 12, 32, 41, 412, 5, 6, 8, 87 };

Print(array);

Console.WriteLine(Sum(array));

Console.WriteLine(SumOfDigits(561));
