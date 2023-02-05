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
