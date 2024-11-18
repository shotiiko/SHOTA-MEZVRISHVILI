// See https://aka.ms/new-console-template for more information
using ConsoleApp1;


class Program
{
    static void Main()
    {
        string personName = "Shota";
        int personAge = 25;

        Person person1 = new Person(personAge, personName);

        Person person2 = person1;
        person2.Name = "Nika";
        person2.Age = 37;

        ChangePerson(person1);

        Console.WriteLine(person1.Name + " " + person1.Age);
        Console.WriteLine(person2.Name + " " + person2.Age);
    }

    static void ChangePerson(Person p)
    {
        p.Name = "Bela";
        p.Age++;
    }
}