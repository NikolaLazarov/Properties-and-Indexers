using static System.Console;
//creating a new class
class Fibs
{
    //creating two static int type variable fields
    private static int last = 1;
    private static int prev = 1;
    //creating a property
    public static int number
    {
        //defining a get method
        get
        {
            //creating a variable equal to the field prev
            int res = prev;
            //assigning the value of "last" to the summation of "last" and "prev"
            last = last + prev;
            //assigning the value of "prev" to the subtraction of "last" and "prev"
            prev = last - prev;
            //retuning the value of the variable "res"
            return res;
        }
        //defing a set method
        set
        {
            //assigning the values of the fields to 1
            prev = 1;
            last = 1;
            //creating a loop
            for (int i = 2; i <= value; i++)
            {
                //assigning the value of "last" to the summation of "last" and "prev"
                last = last + prev;
                //assigning the value of "prev" to the subtraction of "last" and "prev"
                prev = last - prev;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a loop that displays 10 fibonacci numbers with 3 spaces inbetween
        for (int i = 1; i <= 10; i++)
        {
            Write("{0,4}", Fibs.number);
        }
        //displaying a new line
        WriteLine();

        //assigning the value of the property to 6;
        Fibs.number = 6;
        //creating a loop that displays 10 fibonacci numbers with 3 spaces inbetween
        for (int i = 1; i <= 10; i++)
        {
            Write("{0,4}", Fibs.number);
        }
        //displaying a new line
        WriteLine();

        //assigning the value of property to 1;
        Fibs.number = 1;
        //creating a loop that displays 10 fibonacci numbers with 3 spaces inbetween
        for (int i = 1; i <= 10; i++)
        {
            Write("{0,4}", Fibs.number);
        }
        //displaying a new line
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}