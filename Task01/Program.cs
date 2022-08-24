// Задача 1. Про театральную площадь
int n = 6;
int m = 6;
int a = 4;
int x1;
int x2;
if(n%a != 0) 
{
    x1 = n/a+1;
}
else
{
    x1 = n/a;
}
if(m%a != 0) 
{
    x2 = m/a+1;
}
else
{
    x2 = m/a;
}

Console.WriteLine($"Понадобится плиток: {x1*x2}");