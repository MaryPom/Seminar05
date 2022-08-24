// Задача 2. Слоник
Console.WriteLine("Введите значение x: ");
int x = int.Parse(Console.ReadLine());
int result;
if(x%5 != 0)
{
    result = x/5 + 1;
}
else
{
    result = x/5;
}
Console.WriteLine($"Понадобится шагов: {result}");
