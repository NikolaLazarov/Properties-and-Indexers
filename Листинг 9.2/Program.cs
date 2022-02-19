using static System.Console;
class myClass
{
    //creating two public number fields
    private int first;
    private int last;
    //creating a constructor with two int variables as arguments
    public myClass(int a, int b)
    {
        //assigning the  fields
        first = a;
        last = b;
    }
    //creating a ToString method
    public override string ToString()
    {
        //creating a text variable and assigning it
        string text = "Полета на обекта: ";
        text += first + ", " + last;
        //returning the variable
        return text;
    }
    //creating a public number property
    public int number
    {
        //defining a get method
        get
        {
            //switches the values of the variables
            int t = last;
            last = first;
            first = t;
            //returns the variable t
            return t;
        }
        //creating a set method
        set
        {
            //assigning last to first
            last = first;
            //assigning first to the value of the assignment
            first = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class objects with two numbers as arguments
        myClass obj = new myClass(1, 9);

        //displaying the object via a ToString method
        WriteLine(obj);
        //displaying the property
        WriteLine("Свойство number: {0}", obj.number);

        //displaying the object via a ToString method
        WriteLine(obj);
        //assigning the property's value to a number
        obj.number = 5;

        //displaying the object via a ToString method
        WriteLine(obj);
        //displaying the property
        WriteLine("Свойство number: {0}", obj.number);
        //displaying the object via a ToString method

        WriteLine(obj);
        //displaying the property
        WriteLine("Свойство number: {0}", obj.number);
        //displaying the object via a ToString method

        WriteLine(obj);
        //assigning the property's value to a number
        obj.number = 3;

        //displaying the object via a ToString method
        WriteLine(obj);

        WriteLine("Press any key to  close...");
        ReadKey(true);
    }
}