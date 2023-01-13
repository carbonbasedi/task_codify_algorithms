Console.WriteLine("Enter any number here to find smallest digit in it");

int num = Convert.ToInt32(Console.ReadLine());
int small = 9;
int rem = 0;

while (num > 0)
{
    rem = num % 10;
    if (rem < small)
    {
        small = rem;
    }
    num /= 10;
}
Console.WriteLine($"{small} is the smallest digit in given number");
