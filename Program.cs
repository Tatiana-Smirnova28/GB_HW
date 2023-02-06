// Task 1
Console.Clear();

int n = new Random().Next(100, 1000); 
Console.WriteLine(n);
int n1 = n / 100;
int n2 = n % 10;

    Console.WriteLine(n1);

    Console.WriteLine(n2);
Console.WriteLine((n - n1 * 100 - n2)/10);

// Task 2

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100)
    {if (a < 1000)
    {Console.WriteLine(a % 10);}
    else if (a >= 1000)
    { int a2 = ((a % 100) - (a % 10)) / 10;
    Console.WriteLine(a2);}}
else if (a < 100)
    Console.WriteLine("третьего числа нет");

// task 3

Console.Write("Введите день недели: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b >= 6)
    {if (b <= 7)
    {Console.WriteLine("да");}
    else Console.WriteLine("число не подходит");}
else  
Console.WriteLine("нет");