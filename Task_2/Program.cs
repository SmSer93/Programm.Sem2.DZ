Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("The third digit is missing");
while (number > 1000) number = number / 10;  
if (number < 1000 && number > 99)
{
number = number % 10;
Console.WriteLine($"Third digit --> {number}" );
}
     
    
        


