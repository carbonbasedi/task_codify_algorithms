
int num = 100;
int sum = 0;

while (num > 0)
{
    if (num % 13 == 0)
    {
        Console.WriteLine($"{num} divides into 13");
        sum += num;
        num--;
    }
    else
    {
        num--;
    }
}
Console.WriteLine($"{sum} is sum of all numbers that divides into 13 from 100 to 0)");
