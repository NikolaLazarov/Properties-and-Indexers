using static System.Console;
//creating a new class
class myClass
{
    //creating a new class int variable field
    private int code;
    //creating a constrictor that assigns the value of the field
    public myClass(int code) { this.code = code; }
    //overloading a ToString method
    public override string ToString()
    {
        //returns field
        return "Поле code на обекта: " + code;
    }
    //creating an indexer
    public char this[string a, int i, string b, int j]
    {
        //defining a get accessor
        get
        {
            //returns the symbol version of the output 
            return (char)(a[i] - b[j] + code);
        }
        set
        {
            //assign the value of the field of the subtraction
            code = value - (a[i] - b[j]);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass('A');
        //displaying the object
        WriteLine(obj);

        //creating 2 string type variables
        string a = "Alpha", b = "Bravo";

        //creating 2 int type variables
        int i = 2, j = 4;
        //displaying the outcome
        WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);

        //assigning a value of the index
        obj[a, i, b, j] = 'F';
        //displaying the object
        WriteLine(obj);
        //displaying the outcome
        WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);

        //assigning the values of the variables
        a = "Charlie";
        i = 1;
        j = 2;

        //displaying the outcome
        WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}