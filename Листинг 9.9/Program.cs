using static System.Console;
//creating a new class
class myClass
{
    //creating a new class field
    private int num;
    //creating a constructor that assigns the value of the field
    public myClass(int num) { this.num = num; }
    //creating a indexer
    public int this[int k]
    {
        //defining a get method
        get
        {
            //creating a new int variable equal to the object field
            int n = num;
            //creating a loop
            //it loops around k-1 times
            for (int i = 1; i < k; i++)
            {
                //divide the value of n by 10
                n /= 10;
            }
            //return the devision by reminder of n by 10
            return n % 10;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass(12345);
        //creating a loop
        //loops 8 times 
        for (int i = 1; i < 9; i++)
        {
            //display | + the index of filed
            Write(" | " + obj[i]);
        }
        //display | at the end of the loop
        WriteLine(" |");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}