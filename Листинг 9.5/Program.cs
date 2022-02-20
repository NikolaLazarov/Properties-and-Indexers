using static System.Console;
class my_Class
{
    //creating a private number array field
    private int[] nums;
    //creating a property
    public string content
    {
        //defining a get method
        get
        {
            //if the refrance empty
            //return "{}"
            if (nums == null) return "{}";
            //creating a string type variable
            string text = "{" + nums[0];
            //loop that adds the contets of the array to the string
            for (int k = 1; k <= nums.Length; k++)
            {
                text += "," + nums[k];
            }
            //adds a curly brace to the end of the string
            text += "}";
            //reruns the string variable
            return text;
        }
    }
    //creating a property
    public int element
    {
        //defining a set method
        set
        {
            //if nums is empty
            if (nums == null)
            {
                //nums becomes a new array with one element
                nums = new int[1];
                //the element is equal to the value of the assignment
                nums[0] = value;
            }
            else
            {//else creating a new array which has the same length as the array field but +1
                int[] n = new int[nums.Length + 1];
                //assign the contents of the new array to the array fields 
                //but without the last element
                for (int k = 0; k < nums.Length; k++)
                {
                    n[k] = nums[k];
                }
                //the last element is equal to the value of the assignment
                n[nums.Length] = value;
                //a refrance to the new array is stored in a field of the object
                nums = n;
            }
        }
    }
    //creating a new property
    public int[] data
    {
        //defining a get method
        get
        {
            /*creating a new int type array
            its length being the same as the array field of the object
            */
            int[] res = new int[nums.Length];
            //assign the contents of the array to the contents of the array field
            for (int k = 0; k < nums.Length; k++)
            {
                res[k] = nums[k];
            }
            //return the array
            return res;
        }
        //defining a set method
        set
        {
            /*assigning the array field to a new int type array
            its length being the assignments*/
            nums = new int[value.Length];
            //assigning the array field contents
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = value[k];
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        my_Class obj = new my_Class();
        //displaying the array
        WriteLine(obj.content);

        //adding an element
        obj.element = 10;
        //displaying the array
        WriteLine(obj.content);

        //add 2 elements
        obj.element = 5;
        obj.element = 7;
        //displaying the array
        WriteLine(obj.content);

        /*creating a new int type array
        and assigning it to the outcome of the property*/
        int[] A = obj.data;
        //adding an element
        obj.element = 12;

        //displaying the array 'A'
        for (int i = 0; i < A.Length; i++)
        {
            Write(A[i] + " ");
        }
        WriteLine();
        //displaying the array
        WriteLine(obj.content);

        /*creating a new int type array
        and assigning its contents*/
        int[] B = { 11, 3, 6 };

        //assigns the contents of the array to the contents of the array 'B'
        obj.data = B;
        //assigning the first index to 0;
        B[0] = 0;

        //displaying the array 'B'
        for (int i = 0; i < B.Length; i++)
        {
            Write(B[i] + " ");
        }
        WriteLine();

        //displaying the array
        WriteLine(obj.content);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}