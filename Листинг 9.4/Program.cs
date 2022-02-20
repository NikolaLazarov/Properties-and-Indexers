using static System.Console;
//creating a new class
class myClass
{
    //creating a string type field
    private string code;
    //defining a constructor that assigns the value of the property number
    public myClass(uint a)
    {
        number = a;
    }
    //defining a ToString method
    public override string ToString()
    {
        //returns the private field code
        return code;
    }
    //creating a property
    public uint number
    {
        //defining a set method
        set
        {
            /*creating a uint type local variable
            assigning its value to the assigned value of "number"
            */
            uint num = value;
            //assigning the value of the field code to "";
            code = "";
            //creating a do/while loop
            do
            {//do this
                /*assigning the value of code to the outcome of the division by remainder
                plus the value of code
                */
                code = (num % 2) + code;
                //moves one digit to the right
                num >>= 1;
            } while (num != 0);//while the variable num isn't 0
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass(5);
        //displaying the objects field
        WriteLine("Бинарен код на числото 5:\t" + obj);

        //assigning the property's value to 45
        obj.number = 45;
        //displaying the objects field
        WriteLine("Бинарен код на числото 45:\t" + obj);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}