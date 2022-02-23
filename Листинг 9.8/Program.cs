using static System.Console;
//creating a new class
class myClass
{
    //creating a new int type variable field
    private int code;
    //creating a constructor that assigns the value of the field
    public myClass(int code) { this.code = code; }
    //creating an indexer
    public char this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the summation of the field and the argument converted to a character
            return (char)(code + k);
        }
        //defining a set accessor
        set
        {
            /*assigns the value of the field to the subtraction
            of the value of the assignment and the argument
            */
            code = value - k;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass('A');
        //creating a loop that displays letters
        for (int i = 0; i < 10; i++)
        {
            Write(obj[i] + " ");
        }
        //displaying a new line
        WriteLine();

        //accessing the indexer and the set accessor in it
        obj[5] = 'Q';
        //creating a loop that displays letters
        for (int i = 0; i < 10; i++)
        {
            Write(obj[i] + " ");
        }
        //displaying a new line
        WriteLine();

        //creating a loop that displays letters
        for (int i = 0; i < 10; i++)
        {
            Write(obj[-i] + " ");
        }
        //displaying a new line
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}