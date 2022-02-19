using System;
using static System.Console;

namespace Листинг_9._1
{
    //creating a new class
    class myClass
    {
        //creating 3 private fields
        private int num;
        private int min;
        private int max;
        //creating a constructor with two numbers as arguments
        public myClass(int a, int b)
        {
            //the first one is assigned to the min field
            min = a;
            //the second one is assigned to the max field
            max = b;
            //assigning the property code to the summation of the the fields divided in half
            code = (min + max) / 2;
        }
        //creating a public number property
        public int code
        {
            //defining a get method
            get
            {
                //returns the value of the filed num
                return num;
            }
            //defining a set method
            set
            {
                /*if the value of the assignment is less then the filed min
                assign the value of num to min
                */
                if (value < min) num = min;
                /*else if the value of the assignment is greater then the filed max
                assign the value of num to max
                */
                else if (value > max) num = max;
                //else assign the filed num to the value of  the assignment
                else num = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new object with 2 numbers as arguments
            myClass obj = new myClass(1, 9);
            //displaying the property code
            WriteLine("Свойство code: " + obj.code);

            //assigning the property's value to a number
            obj.code = 7;
            //displaying the property code
            WriteLine("Свойство code: " + obj.code);

            //assigning the property's value to a number
            obj.code = 20;
            //displaying the property code
            WriteLine("Свойство code: " + obj.code);

            //assigning the property's value to a number
            obj.code = -10;
            //displaying the property code
            WriteLine("Свойство code: " + obj.code);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
