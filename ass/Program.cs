using System.Drawing;

namespace ass
{
    //class
    //interface
    //struct
    //enum
    internal class Program
    {
        //entry point
        //clr run from here

        static void Main(string[] args)
        {
            #region Question1
            //1. Write a program that allows the user to enter a number then print it.

            int Number = 8;
            Console.WriteLine(Number);

            #endregion


            #region Question2

            //2.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int Value1 = 6;
            int Value2;
            Value2 = Value1; //6

            Value1 = 4;

            Console.WriteLine(Value1); // 6
            Console.WriteLine(Value2); // 4

            #endregion


            #region Question4

            //3.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            object obj1 = new object();
            obj1 = 1;

            object obj2 = new object();
            obj2 = obj1; //1


            obj1 = 2;
            Console.WriteLine(obj1); // 2

            Console.WriteLine(obj2); // 1

            #endregion


          
        }
    }
}
