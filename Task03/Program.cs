// Задача 3. Красивый год
Console.WriteLine("Задайте год: ");
int y = int.Parse(Console.ReadLine());
if(y >= 1000 && y <= 9000)
{
    while(true){
        y = y + 1;
        int x1 = y/1000;
        int x2 = y/100%10;
        int x3 = y/10%10;
        int x4 = y%10;
        if (x1 != x2 && x2 != x3 && x3 != x4 && x1 != x3 && x1 != x4 && x2 != x4)
        {
            break;
        }
    }
    Console.WriteLine($"Следующий год: {y}");
}
else
{
    Console.WriteLine("Год y должен быть 1000 <= y <= 9000");
}

