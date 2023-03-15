Console.WriteLine("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x3 = ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y3 = ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z3 = ");
int z3 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

Console.WriteLine(Math.Sqrt(A * A + B * B + C * C));