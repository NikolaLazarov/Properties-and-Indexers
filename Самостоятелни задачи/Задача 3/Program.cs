using static System.Console;
class myClass
{
    private int[] nums = new int[0];
    public myClass(int[] numeros)
    {
        Array.Resize(ref nums, numeros.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = numeros[i];
        }
    }
    public int mun
    {
        get
        {
            int n = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                n += nums[i];
            }
            return n;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int[] k = { 3, 4, 5 };
        myClass obj = new myClass(k);
        WriteLine(obj.mun);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}