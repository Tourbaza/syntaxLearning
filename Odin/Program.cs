double dhsToRub = 16.63;
double dhsToUsd = 0.27;
double dhs;

Console.WriteLine("Введите количество дирхам");
dhs = float.Parse(Console.ReadLine());

Console.WriteLine($"{dhs} dirhams = {dhs * dhsToUsd} dollars");
Console.WriteLine($"{dhs} dirhams = {dhs * dhsToRub} rubles");

