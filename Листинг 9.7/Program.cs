using static System.Console;
//creating a new class
class my_Class
{
    //creating a new private int type array field
    private int[] nums;
    //creating a constructor
    public my_Class(int n)
    {
        //assigning the fields value to a new int array with the length of the argument of the constructor
        nums = new int[n];
        //assigning each index to 0 with a for loop
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
    //overloading a ToString method
    public override string ToString()
    {
        //returns the contents inside of curly braces
        string txt = "{" + nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            txt += "," + nums[i];
        }
        txt += "}";
        return txt;
    }
    //creating a property
    public int length
    {
        //defining a get method
        get
        {
            //returns the array fields lenght
            return nums.Length;
        }
    }
    //creating an indexer
    public int this[int i]
    {
        //defining a get method
        get
        {
            //return the index of the array field
            //the index is defined by the argument
            return nums[i];
        }
        //defining a set method
        set
        {
            //assigning the array fields index to the value of assignment
            nums[i] = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        my_Class obj = new my_Class(5);
        //displaying the array field
        WriteLine(obj);

        //assigning each of the indexes of the array filed with odd numbers
        for (int i = 0; i < obj.length; i++)
        {
            obj[i] = 2 * i + 1;
        }
        //displaying the array field
        WriteLine(obj);

        //displaying the array field contents
        for (int i = 0; i < obj.length; i++)
        {
            Write(" " + obj[i]);
        }
        //displaying a new line
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}