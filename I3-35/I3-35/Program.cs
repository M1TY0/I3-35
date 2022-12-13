int year = int.Parse(Console.ReadLine());
string month = Console.ReadLine();
Dictionary<string, int> map = new Dictionary<string, int>();
map.Add("January", 0);
map.Add("February", 1);
map.Add("March", 2);
map.Add("April", 3);
map.Add("May", 4);
map.Add("June", 5);
map.Add("July", 6);
map.Add("August", 7);
map.Add("September", 8);
map.Add("Octomber", 9);
map.Add("November", 10);
map.Add("December", 11);
int theMount = map[month];
int[] mounts = new int[12];
for (int i = 0; i < 7; i++)
{
    if (i == 1)
    {
        mounts[i] = 28;
    }
    else if (i % 2 == 0)
    {
        mounts[i] = 31;
    }
    else if (i % 2 != 0)
    {
        mounts[i] = 30;
    }
}
for (int i = 7; i < 12; i++)
{
    if (i % 2 == 0)
    {
        mounts[i] = 30;
    }
    else if (i % 2 != 0)
    {
        mounts[i] = 31;
    }
}

if (year % 4 == 0)
{
    mounts[1] = 29;
}
int line = 0;
Console.WriteLine();
for (int i = 1; i <= mounts[theMount]; i++)
{
    if (line%7 == 0)
    {
        Console.WriteLine();
    }

    Console.Write(i +" ");
    line++;

}