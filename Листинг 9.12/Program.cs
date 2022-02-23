using static System.Console;
//creating a new class
class myClass
{
    //creating a new char type 2D array field
    private char[,] symbs;
    //creating a constructor
    public myClass(int a, int b)
    {
        //assigning the field to a new char array
        symbs = new char[a, b];
        //filling the array with the character 'O'
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                symbs[i, j] = 'O';
            }
        }
    }
    //creating a new public method
    public void show()
    {
        //displays the field
        WriteLine("Двумерен масив: ");
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Write(symbs[i, j] + " ");
            }
            WriteLine();
        }
    }
    //creating a new indexer
    public char this[int i, int j]
    {
        //defining a get accessor
        get
        {
            //return the array field by the indexes
            return symbs[i, j];
        }
        //defining a set accessor
        set
        {
            //assigning the field by the indexes is equal to the value of the assignment
            symbs[i, j] = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass(2, 3);
        //using the method show in the object
        obj.show();

        //assigning the value of field by the indexes
        obj[0, 0] = 'A';
        obj[1, 2] = 'Z';
        //using the method show in the object
        obj.show();

        //checks
        WriteLine("Проверка: ");

        //displaying the outputs
        WriteLine("obj[0,0] = {0}", obj[0, 0]);
        WriteLine("obj[1,1] = {0}", obj[1, 1]);
        WriteLine("obj[1,2] = {0}", obj[1, 2]);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}