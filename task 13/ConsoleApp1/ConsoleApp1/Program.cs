using System.Collections;
using System.Security.AccessControl;

// ARRAYLIST

{
    {
        int[] num = { 1, 2, 3, 4, 5, 6 };

        var sia = new ArrayList();
        sia.Add(1);
        sia.Add(2);

        Console.WriteLine("damateba");

        foreach (int i in sia)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("tsashla");

        sia.Remove(1);
        foreach (int i in sia)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("INSERTI");
        sia.Insert(0, 2);

        foreach (int i in sia)
        {
            Console.WriteLine(i);
        }
    }
}

//LIST
List<int> CARS = new List<int> {6, 5, 7};
CARS.Add(9);
CARS.AddRange(new List<int>() { 1, 2 });
foreach (int i in CARS)
{
    Console.WriteLine(i);
}
CARS.Sort();
foreach (int i in CARS)
{
    Console.WriteLine(i);
}


//Dictionary

Dictionary<int, string> dic = new Dictionary<int, string>();
dic.Add(1, "shotiko");
dic.Add(2, "shota");

Console.WriteLine(dic[1]);
Console.WriteLine(dic[2]);

foreach ( var  shotii in dic)
{
    Console.WriteLine(shotii.Key);   
    Console.WriteLine(shotii.Value); 
}


//SortedList

SortedList<int, string> saxeli = new SortedList<int, string>();
saxeli.Add(1, "shoto");
saxeli.Add(2, "shoot");

foreach (var i in saxeli)
{
    Console.WriteLine(i);
}
saxeli.RemoveAt(saxeli.Count - 1);

foreach (var i in saxeli)
{
    Console.WriteLine(i);
}
saxeli[1] = "se";

foreach (var i in saxeli)
{
    Console.WriteLine(i);
}

//stac

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);

foreach (int i in stack)
{
    Console.WriteLine(i);
}

Console.WriteLine(stack.Peek());


//Queue

Queue<string> queue = new Queue<string>();
queue.Enqueue("nika");
queue.Enqueue("alina");
queue.Enqueue("ia");

foreach (var i in queue)
{
    Console.WriteLine(i);
}
Console.WriteLine(queue.Peek());

// SortedDictionary

SortedDictionary<int, string> xili = new SortedDictionary<int, string>();
xili.Add(2, "VASHLI");
xili.Add(4, "msxali");
xili.Add(3, "BANANI");

foreach (var i in xili)
{
    Console.WriteLine(i.Key);
    Console.WriteLine(i.Value);
}

//HashSet

HashSet<int> dubli1 = new HashSet<int>();
HashSet<int> dubli2 = new HashSet<int>();
dubli1.Add(2);
dubli1.Add(4);
dubli1.Add(3);
dubli1.Add(3);

dubli2.Add(6);
dubli2.Add(8);

dubli1.UnionWith(dubli2);

foreach (int i in dubli1)
{
    Console.WriteLine(i);
}




















