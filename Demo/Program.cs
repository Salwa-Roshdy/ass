using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Error Types


            #region Syntax Error - Compilation Error

            //console.WriteLine("Hello");
            // iint x;
            #endregion


            #region RunTime Error

            //int X = 5;
            // int Y = 0;
            //Console.WriteLine(X/Y);
            #endregion


            #region Logical Error

            // int A = 10;
            // int B = 5;
            //  Console.WriteLine(Sum(A,B));

            #endregion


            #region Warning
            // int x = 5; // 4 Byte
            //Console.WriteLine(x);

            #endregion


            #endregion


            #region Variable

            //5
            int Number = 5;

            #endregion


            #region Value Type

            int X; // 4 Byte
            // Console.WriteLine(X);
            X = 4;
            int Y = 9; //4 Byte

            Y = X; // 4
            X++; //5

            Console.WriteLine(X);
            Console.WriteLine(Y);
            #endregion

            #region Reference Type
            Point P01;
            P01 = new Point();

            Point P02 = new Point();

            P02 = P01;

            //P01.x = 10;
            //Console.WriteLine(P02.x);


            #endregion

            #region Object
            //PoINT P01=new Point();
            //P01.

            object obj01 = new object();
            //obj01 = 1;
            // obj01 = "Hello";
            // obj01 = 'A';
            //obj01 = true;
            object obj02 = new object();
            Console.WriteLine(obj01.GetHashCode());
            Console.WriteLine(obj02.GetHashCode());

            obj02 = obj01;
            Console.WriteLine("");
            Console.WriteLine(obj01.GetHashCode());
            Console.WriteLine(obj02.GetHashCode());




            #endregion

            #region Fractions and Discard

            //int Num01 = 12345678999;
            // long Num02= 12345678999;

            double Num03 = 22.2;
            float Num04 = 22.2F;
            decimal Num05 = 22.2m;

            int Num06 = 1_000_000;
            Console.WriteLine(Num06); //1000000



            #endregion
        }
    }
}
