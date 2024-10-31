// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int input = int.Parse(Console.ReadLine());
if (input >= 1 && input <= 7)
{

    switch (input)
    {
        case 6:
            Console.WriteLine("kvira");
            break;
        case 1:
            Console.WriteLine("orshabati");
            break;

        case 2:
            Console.WriteLine("samshabati");
            break;

        case 3:
            Console.WriteLine("otkhshabati");
            break;
        case 4:
            Console.WriteLine("khutshabati");
            break;
        case 5:
            Console.WriteLine("paraskevi");
            break;
        default:
            Console.WriteLine("shabati");
            break;
    }
}
 else  Console.WriteLine("rickhvi arastsoria");