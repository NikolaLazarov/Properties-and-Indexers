using static System.Console;
class myClass
{
    int i = 1;
    public int num
    {
        get
        {
            return i;
            i += 2;
        }
        set
        {
            i = -1;
            for (int j = 1; j <= value; j++)
            {
                i += 2;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();

        WriteLine(obj.num);
        WriteLine(obj.num);

        obj.num = 5;
        WriteLine(obj.num);

        WriteLine("Press any key to close...");
    }
}