int x = int.Parse(Console.ReadLine());
bool endless = true;

while (endless)
{
    switch (x)
    { 
        case 1:
            Console.WriteLine("Раз");
            break;
        case 2:
            Console.WriteLine("Два");
            break;
        case 3:
            Console.WriteLine("Три");
            break;
        case 4:
            endless = false;
            break;
        default:
            Console.WriteLine("Шо это, иди отсюда со своим этим самым");
            break;

    }
    x = int.Parse(Console.ReadLine());
}