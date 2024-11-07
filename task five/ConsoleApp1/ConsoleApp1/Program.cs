// See https://aka.ms/new-console-template for more information


Console.WriteLine("datseret pirveli studentis sakheli");
string first = Console.ReadLine();
Console.WriteLine("datseret meore studentis sakheli");
string second = Console.ReadLine();
Console.WriteLine("datseret mesame studentis sakheli");
string third = Console.ReadLine();
string[] students = { first, second, third };
Console.WriteLine("kvela studentis sakhelia");
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

int[,] grades = new int[3,2];


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine("sheiyvanet " + (i+1) +" studentis "+(j+1) +" qula");
        grades[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0;i < 3;i++)
{
    Console.WriteLine(students[i] + " " + grades[i,0] + " " + grades[i,1]);
}



