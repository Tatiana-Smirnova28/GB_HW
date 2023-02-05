// Task 1
Console.Clear();

Console.Write("First number");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number");
int m = Convert.ToInt32(Console.ReadLine());


if (n>m)
    Console.WriteLine($"max = {n}");

else if (n<m)
    Console.WriteLine($"max = {m}");

else
    Console.WriteLine("equal");

// Task 2
Console.Clear();

Console.Write("First number");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Third number");
int c = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    if (a>c)
    {
        Console.WriteLine($"Max = {a}");
    }
    else
    {
        Console.WriteLine($"Max = {c}");
    }
}

else if (b > c)
{
    Console.WriteLine($"Max = {b}");
}
else
{
    Console.WriteLine($"Max = {c}");
}

// Task 3

Console.WriteLine("Введите число: ");
int d = Convert.ToInt32(Console.Read()); 
if (d % 2 == 0) 
{ Console.WriteLine("да"); }
else 
{ Console.WriteLine("нет"); }

// task 4

Console.Clear();

Console.Write("Введите число: ");
int e = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= e; i++; i % 2 == 0);
  { Console.WriteLine($"{i} "); }

   Console.WriteLine();

