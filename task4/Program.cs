Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) 
{
    Console.WriteLine("Это число является максимальным: " + a);
}
else if (b > a && b > c)
{
    Console.Write("Это число является максимальным: " + b);
}
else 
{
    Console.Write("Это число является максимальным: " + c);
}