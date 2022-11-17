Console.WriteLine("Введите сколько первых простых чисел вычислить");
int n = int.Parse(Console.ReadLine());

int numDiv;

Console.WriteLine($"Первые {n} простых чисел:");
for (int i = 1; n != 0; i++)
{
    numDiv = 0;
    for(int o = 1; o <= i / 2; o++)
    {
        if (i % o == 0)
        {
            numDiv++;
        }
    }
    if (numDiv < 2)
    {
        n--;
        Console.WriteLine(i);
    }
}
