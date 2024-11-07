// See https://aka.ms/new-console-template for more information


//int input = int.Parse(Console.ReadLine());
//if (input >= 1 && input <= 7)
//{

//    switch (input)
//    {
//        case 6:
//            Console.WriteLine("kvira");
//            break;
//        case 1:
//            Console.WriteLine("orshabati");
//            break;

//        case 2:
//            Console.WriteLine("samshabati");
//            break;

//        case 3:
//            Console.WriteLine("otkhshabati");
//            break;
//        case 4:
//            Console.WriteLine("khutshabati");
//            break;
//        case 5:
//            Console.WriteLine("paraskevi");
//            break;
//        default:
//            Console.WriteLine("shabati");
//            break;
//    }
//}
// else  Console.WriteLine("rickhvi arastsoria");

// მეორე დავალება

//int jami = 0;
//while (true)
//{
//    Console.WriteLine("sheikvane ritskhvi: ");
//    int input2 = int.Parse(Console.ReadLine());

//    if (input2 < 0)
//    {
//        Console.WriteLine("dajamebuli ritskhvia:" + jami);
//        break;
//    }
//    jami = jami + input2;
//}
//Console.WriteLine("shekreba dasrulebulia");

//მესამე დავალება

Console.WriteLine("sheikvane ritskhvi 1dan 10mde: ");
int input4 = int.Parse(Console.ReadLine());
Console.WriteLine("migebuli namravli");
for (int i = 1; i <= 10; i++)
{
    int namravli = (i * input4);
    {
        Console.WriteLine($"{i} * {input4} = {namravli}");
    }
}




