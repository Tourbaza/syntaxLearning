int[] array = { 5, 96, 77, 58, 49, 395, 5, 1, 48, 100 };
int[] subArray = array[2..^1];

for(int i = 0; i < subArray.Length; i++)
{
    Console.WriteLine(subArray[i]);
}
