Console.WriteLine("Enter any number here to find sum of its digits and check if sum is even or odd");

int num = Convert.ToInt32(Console.ReadLine());
int rem = 0;
int sum = 0;

while (num > 0)
{
    rem = num % 10;
    sum += rem;
    num /= 10;
}
if (sum % 2 == 0)
{
    Console.WriteLine($"Sum of digits is {sum} which is even");
}
else
{
    Console.WriteLine($"Sum of digits is {sum} which is odd");
}
