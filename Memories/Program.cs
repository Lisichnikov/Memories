Console.WriteLine("Привет чувачок");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < Math.Abs(x); i++)
{
    result += Math.Abs(y);
}
if (x > 0 && y > 0)
    Console.WriteLine(x + " * " + y + " = " + result);
if (x < 0 && y < 0)
    Console.WriteLine(x + " * " + y + " = " + result);
if (x > 0 && y < 0) 
    Console.WriteLine(x + " * " + y + " = " + "-" + result);
if (x < 0 && y > 0)
    Console.WriteLine(x + " * " + y + " = " + "-" + result);
