using static System.Console;
//creating a new class
class myClass
{
    //creating a new public int type variable field
    public int code;
    //creating a constructor that assigns the value of the field
    public myClass(int n)
    {
        code = n;
    }
    //creating a new indexer
    public int this[myClass obj]
    {
        //defining a get accessor
        get
        {
            //returns the subtraction of the field and the arguments field
            return code - obj.code;
        }
        //defining a set accessor
        set
        {
            //assigns the value of the field to the field of the argument + the value of the assignment
            code = obj.code + value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass A = new myClass(100);
        //displaying the objects field
        WriteLine("Обект A: {0}", A.code);

        //creating a new class object
        myClass B = new myClass(150);
        //displaying the objects field
        WriteLine("Обект B: {0}", B.code);

        //creating a new variable and assigning its value the indexer
        int num = A[B];
        //displaying the outcomes
        WriteLine("Израз A[B]: {0}", num);
        WriteLine("Израз B[A]: {0}", B[A]);

        //assigning the fields value to the summation of the B field and 200
        A[B] = 200;
        //displaying the field
        WriteLine("Обект A: {0}", A.code);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}