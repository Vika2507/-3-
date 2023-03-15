Console.WriteLine("Введите число");
string n = Console.ReadLine();
int len = n.Length;

if (len == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"{n} палиндом");
    }
    else
    {
        Console.WriteLine($"не палиндом");
    }
}
else 
{
    Console.WriteLine("Вы введи не пятизначное число");
}