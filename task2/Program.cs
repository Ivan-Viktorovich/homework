Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("Это число является максимальным: " + a);
}
else 
{
    Console.Write("Это число является максимальным: " + b);
}