Console.WriteLine("sheikvanet mreli ritskhvi");

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    int input = int.Parse(Console.ReadLine());
     array[i] = input;
}

Console.WriteLine("sheikvanet masivi");
int index = int.Parse(Console.ReadLine());

int sum = sumritskhvi(array, index);
Console.WriteLine("sumi" + sum);

static int sumritskhvi(int[] array, int index)
{
    int arrayNumber = array[index];
    int sum = 0;
    while (arrayNumber > 0)
    {
        sum += arrayNumber % 10;
        arrayNumber /= 10;
    }
    return sum;
}