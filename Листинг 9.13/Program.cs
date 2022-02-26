using static System.Console;
//creating a new class
class myClass
{
    //creating a int array variable field
    private int[] vals;
    //creating a char array variable field
    private char[] ckey;
    //creating a string array variable field
    private string[] skey;
    //creating a new method that adds an element to the arrays
    private void add(char a, string b, int n)
    {
        //creating a number variable
        int size;
        //creating a char array variable
        char[] s;
        //creating a string array variable
        string[] t;
        //creating a int array variable
        int[] v;
        //if the int filed is nothing the variable size is equal to 1
        if (vals == null) size = 1;
        //else the size is equal to int filed's length + 1
        else size = vals.Length + 1;
        //assigning the char array variable to a new char array
        s = new char[size];
        //the last element is equal to the coresponding argument
        s[s.Length - 1] = a;
        //assigning the string array variable to a new string array
        t = new string[size];
        //the last element is equal to the coresponding argument
        t[t.Length - 1] = b;
        //assigning the string array variable to a new string array
        v = new int[size];
        //the last element is equal to the coresponding argument
        v[v.Length - 1] = n;
        //creating a loop that duplicates the arrays
        for (int k = 0; k < size - 1; k++)
        {
            s[k] = ckey[k];
            t[k] = skey[k];
            v[k] = vals[k];
        }
        //assigns new value of the fields
        ckey = s;
        skey = t;
        vals = v;
    }
    //overloading a ToString method
    public override string ToString()
    {
        //creating a string variable
        string txt = "Съдържание на обекта:\n";
        //adding the values of the fields to the variable
        //if the field vals isn't equal to nothing
        if (vals != null)
        {
            for (int k = 0; k < ckey.Length; k++)
            {
                //add to the string the values of the field
                txt += ckey[k] + " : " + skey[k] + " : " + vals[k] + "\n";
            }
        }//else return an empty field
        else
        {
            txt += "Празен обект\n";
        }
        //return the variable
        return txt;
    }
    //creating an indexer
    public int this[char a, string b]
    {
        //defining a get accessor
        get
        {
            //if the int array variable isn't nothing
            if (vals != null)
            {
                //checks each of the elements
                for (int k = 0; k < ckey.Length; k++)
                {
                    //if the arguments coincide
                    if (a == ckey[k] && b == skey[k])
                    {
                        //return the value of the index of the coincidence
                        return vals[k];
                    }
                }
            }
            //creating a inr type variable
            int res = 0;
            //using the method add
            add(a, b, res);
            //returns the variable;
            return res;
        }
        //defining a set accessor
        set
        {
            //if the field isn't nothing
            if (vals != null)
            {
                //checks each of the elements
                for (int k = 0; k < ckey.Length; k++)
                {
                    //if there is a coincidence between them and the arguments
                    if (a == ckey[k] && b == skey[k])
                    {
                        //the value of the index of the field is equal to the value of the assignment
                        vals[k] = value;
                        //end the cycle
                        return;
                    }
                }
            }
            //using the method add
            add(a, b, value);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass();
        //displaying the object
        Console.WriteLine(obj);

        //displaying the value of the element
        Console.WriteLine("Стойност на елемента: " + obj['A', "Първи"] + "\n");
        //displaying the object
        Console.WriteLine(obj);

        //assigning values to the object
        obj['B', "Втори"] = 200;
        obj['C', "Трети"] = 300;

        //displaying the object
        Console.WriteLine(obj);

        //displaying the value of the element
        Console.WriteLine("Стойност на елемента: " + obj['B', "Първи"] + "\n");
        //displaying the value of the element
        Console.WriteLine("Стойност на елемента: " + obj['B', "Втори"] + "\n");
        //displaying the value of the element
        Console.WriteLine("Стойност на елемента: " + obj['A', "Трети"] + "\n");
        //displaying the value of the element

        //displaying the object
        Console.WriteLine(obj);
        //assigning a value to the object
        obj['A', "Първи"] = 100;
        //displaying the object
        Console.WriteLine(obj);
        //displaying the value of the element
        Console.WriteLine("Стойност на елемента: " + obj['A', "Първи"] + "\n");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
