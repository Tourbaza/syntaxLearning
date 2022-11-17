bool wannaEat = false;

Console.WriteLine("Wanna eat?");
string answer = Console.ReadLine();
if (answer == "y" || answer == "yes")
{
    wannaEat = true;
}
else if(answer == "n" || answer == "no")
{
    wannaEat = false;
}

if (wannaEat)
{
    Console.WriteLine("Get yo big N tasty burger!");
}
else
{
    Console.WriteLine("Eat lettucce*skull*");
}