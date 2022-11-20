Console.WriteLine("Enter a third-digit number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{ 
    number = number /10 % 10;
    Console.WriteLine($"Second digit --> {number}" );
}
