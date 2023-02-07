int[] array = new int[8];
System.Console.WriteLine("enter 'a' if you want to fill in manually or enter 'b' if you want to fill in automatically");
string variant = Console.ReadLine();
switch ( variant )
{   
    case "a":
      void AddDigitalToArray1 (int[] digital)
        {

           for ( int i=0 ;  i < digital.Length; i++)
            {
                digital[i] = new Random().Next(0, 100001); //исскуственно ограничил 100000
            }    

        } 

        AddDigitalToArray1(array);

        break;

    case "b":
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

       void AddDigitalToArray (int[] digital)
        {

           for ( int i=0 ;  i < digital.Length; i++)
            {
                digital[i] = ReadInt1("number"); 
            }    

        }       
       
        AddDigitalToArray(array);
        break;


    default:
        System.Console.WriteLine("Incorrect value");
        break; 
}




void Printarray(int[] digit)
{
    for( int i =0 ; i< digit.Length; i++)
    {
        System.Console.Write($" {digit[i]}");
        
    }
}

Printarray(array);