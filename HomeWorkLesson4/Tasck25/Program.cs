Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine($" Результат: " + step);