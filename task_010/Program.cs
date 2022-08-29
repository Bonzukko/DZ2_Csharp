Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while(Math.Abs(num)<100 || Math.Abs(num)>999)
{
    Console.WriteLine("Введите трёхзначное число");
    num = Convert.ToInt32(Console.ReadLine());
 }
Console.Clear();
Console.WriteLine(num + " -> " + Math.Abs(num) % 100/10);