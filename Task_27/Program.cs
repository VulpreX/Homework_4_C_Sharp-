int ReadInt(string argument)
{
    Console.Write($"Enter {argument} - ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine(" You entered an invalid number, try againe!");
    }

    return number; 
}

int SumOfDigits( int number)
{
    int sum=0;
    int f;
    while (number >0)
    {   
        f = number % 10;
        sum = sum + f;
        number= number / 10;
    }

    return sum;    
}   
System.Console.WriteLine($"Sum of the digit of this number = {SumOfDigits(ReadInt("Number"))}");