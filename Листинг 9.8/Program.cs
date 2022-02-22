using static System.Console;
//creating a new class
class my_String
{
    //creating a new private string type class field
    private string text;
    //creating a constructor that assigns the value of the field
    public my_String(string txt) { text = txt; }
    //creating a new operator
    public static implicit operator my_String(string txt)
    {
        //returns a new my_String object
        return new my_String(txt);
    }
    //overloading a ToString method
    public override string ToString() { return text; }//returns the object filed
    //creating a new char type indexer
    public char this[int k]
    {
        //defining a set method
        set
        {
            //if the index is lower than zero or is higher than the fields length
            //do nothing
            if (k < 0 || k >= text.Length) return;
            //creating a new string type variable
            string t = "";
            //loop that assigns each index until the arguments value
            for (int i = 0; i < k; i++) { t += text[i]; }
            //adding the assignment to the variable
            t += value;
            //loop that finishes to assign each index
            for (int i = k + 1; i < text.Length; i++) { t += text[i]; }
            //the field is equal to the variable
            text = t;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        my_String txt = "Муха";
        //displaying the field
        WriteLine(txt);

        //assigning the index's value
        txt[-1] = 'K';
        //displaying the field
        WriteLine(txt);

        //assigning the index's value
        txt[4] = 'Ъ';
        //displaying the field
        WriteLine(txt);

        //assigning the index's value
        txt[0] = 'С';
        //displaying the field
        WriteLine(txt);

        //assigning the index's value
        txt[1] = 'л';
        //displaying the field
        WriteLine(txt);

        //assigning the index's value
        txt[2] = 'о';
        WriteLine(txt);

        //assigning the index's value
        txt[3] = 'н';
        //displaying the field
        WriteLine(txt);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}