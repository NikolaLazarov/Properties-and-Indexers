using static System.Console;
class myClass
{
    private char s;
    public char charater
    {
        get
        {
            return s;
        }
        set
        {
            if ((int)value < 65 || (int)value > 90)
            {
                WriteLine("Please enter a charater between A and Z");
            }
            else
            {
                s = value;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();

        obj.charater = 'B';
        WriteLine(obj.charater);
        obj.charater = '@';

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}