using static System.Console;
class myClass
{
    private int[] nums;
    int p;
    public myClass(int n)
    {
        p = 1;
        for (int i = 0; i <= n; i++) { p *= 10; }
        nums = new int[n];
    }
    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < nums.Length; i++)
        {
            str += nums[i] + " ";
        }
        return str;
    }
    public int this[int i]
    {
        set { nums[i] = value; }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass(4);
        WriteLine(obj);
        obj[1] = 6;
        obj[2] = 9;
        WriteLine(obj);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}