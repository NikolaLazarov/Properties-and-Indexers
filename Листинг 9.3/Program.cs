using static System.Console;
//creating a new class
class myClass
{
    //creating 2 public whole number fields
    public int first;
    public int last;
    //creating a constructor to assign the values of the fields
    public myClass(int a, int b)
    {
        //assigning the value of the first field
        first = a;
        //assigning the value  of the last field
        last = b;
    }
    //creating a property
    public int sum
    {
        //defining a get method
        get
        {
            //returns the summation of the fields
            return first + last;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass(1, 9);
        //displaying the output of the property
        WriteLine("Сумата на полетата: {0}", obj.sum);

        //resigning the field first to 6;
        obj.first = 6;
        //displaying the output of the property
        WriteLine("Сумата на полетата: {0}", obj.sum);

        //resigning the field "last" to 2;
        obj.last = 2;
        //displaying the output of the property
        WriteLine("Сумата на полетата: {0}", obj.sum);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}