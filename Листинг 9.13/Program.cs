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
                    if (a == ckey[k] && b == skey[k])
                    {
                        return vals[k];
                    }
                }
            }
            int res = 0;
            add(a, b, res);
            return res;
        }
        set
        {
            if (vals != null)
            {
                for (int k = 0; k < ckey.Length; k++)
                {
                    if (a == ckey[k] && b == skey[k])
                    {
                        vals[k] = value;
                        return;
                    }
                }
            }
            add(a, b, value);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Създаване на обект:
        myClass obj = new myClass();
        // Проверка на съдържанието на обекта:
        Console.WriteLine(obj);
        // Проверка на стойността на елемент:
        Console.WriteLine("Стойност на елемента: " + obj['A', "Първи"] + "\n");
        // Проверка на съдържанието на обекта:
        Console.WriteLine(obj);
        // Присвояване на стойност на елемент:
        obj['B', "Втори"] = 200;
        // Присвояване на стойност на елемент:
        obj['C', "Трети"] = 300;
        // Проверка на съдържанието на обекта:
        Console.WriteLine(obj);
        // Проверка на стойността на елемент:
        Console.WriteLine("Стойност на елемента: " + obj['B', "Първи"] + "\n");
        // Проверка на стойността на елемент:
        Console.WriteLine("Стойност на елемента: " + obj['B', "Втори"] + "\n");
        // Проверка на стойността на елемент:
        Console.WriteLine("Стойност на елемента: " + obj['A', "Трети"] + "\n");
        // Проверка на съдържанието на обекта:
        Console.WriteLine(obj);
        // Присвояване на стойност на елемент:
        obj['A', "Първи"] = 100;
        // Проверка на съдържанието на обекта:
        Console.WriteLine(obj);
        // Проверка на стойността на елемент:
        Console.WriteLine("Стойност на елемента: " + obj['A', "Първи"] + "\n");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}