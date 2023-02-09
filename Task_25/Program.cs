int ReadInt1(string argument1)
{
    Console.Write($"Enter {argument1} - ");
    int number1;

    while(!int.TryParse(Console.ReadLine(), out number1))
    {
        System.Console.WriteLine(" You entered an invalid number, try againe!");
    }

    return number1; 
}

int Exponentiate(int number1, int number2)
{
    int f = number1;

    for (int i = 1; i < number2; i++)
    {
        f= number1 * f ;
    } 
       
    return f;    
}

System.Console.WriteLine($"Number 1 to the natural extent of number 2 = {Exponentiate((ReadInt1 ("Number1")),( ReadInt1("Number2")))}");