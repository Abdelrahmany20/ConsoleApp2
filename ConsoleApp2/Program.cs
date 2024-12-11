namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo

            #region Error Types

            #region Syntax Errors
            //console.WriteLine("Hello Route");
            //IInt x = 5;
            //
            #endregion
            #region RunTime Error
            //int X = 5;
            //int Y = 0;
            //Console.WriteLine(X / Y);



            #endregion
            #region Logical Errors
            // int A = 5;
            // int B = 4;
            // Console.WriteLine(sum(A + B));
            // static int Sum(int x, int Y);
            // {
            //     return x - Y;
            // }
            //
            #endregion
            #region warning
            // int x;
            #endregion




            #endregion ;

            #region variables

            //5
            // int X = 5;
            // X = 6;
            // Console.WriteLine(X);
            // X = 7;
            //X = "Mostafa";
            // string Name = "Mostafa";


            #endregion;

            #region data Types
            #region  Built in value Type (struct)
            //byte          Sbyte       1 Byte
            //short         UShort      2 Byte
            // int          Uint        4 Byte
            // Long         Ulong       8 Byte


            // Float                    4 Byte
            // Double                   8 Byte
            // Decimal                  16 Byte


            // Char                    2 Byte
            // Bool                    1 Byte
            // Datetime                8 Byte

            #endregion
            #region Built in refrence Type (Class)

            //Object
            //String
            //Array
            //Delegate
            #endregion
            #region CTS - CLS
            //  int X; // 4 Byte
            // string Name = "Ahmed"; // 10 Byte
            // Name = "Ali":
            #endregion
            #region Value type
            // int X;
            // Allocate 4 Bytes in Stack
            // X = 5;
            // int Y = 9;
            // Y = X; // 5

            //  X++; // 6
            // Console.WriteLine(X);
            // Console.WriteLine(Y);

            #endregion
            #region Reference Type
            // Point P1;
            // Allocate 4 Bytes in Stack
            // Zero Bytes Allocate at Heap
            //P1 = new Point();
            // 1. Allocate Required Bytes at Heap
            // 2. Initialize (Cross Out) Allocated Bytes Of Object
            // 3. Call User Defined Constructor If Exist
            // 4. Assign Reference (P1) To Allocated Object
            // Point P2 = new Point();
            // P2 = P1;
            // P1.x = 10;
            // Console.WriteLine(P2.x);
            #endregion
            #region object

            //1.Generics
            //Public Void Print<T>(T item)
            //Console.writeline(item);
            //Print<int>(2);
            //Print<string>("Ahmed");
            //Print<Char>('A');
            //Print<bool>(True);

            //object 01 = new object();
            //object 02 = new object();
            //Console.WriteLine(01.GetHashCode());
            //Console.WriteLine(02.GetHashCode());
            //02 = 01;
            //Console.WriteLine("''''''''''''''''''''''''");
            //Console.WriteLine(01.GetHashCode());
            //Console.WriteLine(02.GetHashCode));
            //

            #endregion
            #region Fractions and Discard
            // long X = 11234545606918121;
            // double Y = 22222222.2;
            // float Num01 = 2.2F;
            // decimal Num02 = 2.2m;
            // int Num03 = 1_000_000;
            // Console.WriteLine(Num03);
            #endregion

            #endregion


            #endregion



            #region Question 1

            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();
            Console.WriteLine("The Number is: " + input);


            #endregion

        }
    }
}
