using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_1
{
    public class Lesson1
    {
        //Example of variables of different data types

        //primitives
        byte x = 0;
        int i = 0;
        double d = 0.01;
        float f = 0.5f;
        long l = 1L;
        char c = 'a';
        bool b = true;

        //reference types
        string s = "sometexthere";
        IList<int> list = new List<int>();

        //constants
        public const double Pi = 3.14159;
        public const int SpeedOfLight = 300000;

        static public void Main(String[] args)
        {
            //operators
            //arithmetic: +,-,*,/,%
            int a = 5, b = 10;
            int summ = a + b;
            int substraction = b - a;
            int multiplication = a * b;
            int division = b / a;
            int mod = b % a;
            //relational: <, <=, >=, ==, !=
            bool result1 = a < b; //true
            bool result2 = b <= a; //true
            bool result3 = a >= b; //false
            bool result4 = b == a; //false
            bool result5 = b != a; //true
            //logical operators: &&, ||, !
            int z = 1, x = 20;
            if (z < x && x <= 20)
            {
                //some code here
                Console.WriteLine("Both conditions are correct");
            }
            string str = "hello";
            if (str == "Hello" || str == "hello")
            {
                //some code here
                Console.WriteLine("print hello or Hello");
            }
            if (!(z + x < 20))
            {
                //some code here
                Console.WriteLine(" z+x must not be less than 20")
            }
            //assignment: =, +=, -=, *=, /=, %=
            int w, r;
            w = r = 8;
            w += r; // w = w + r; 
            w -= r; // w = w - r;
            w *= r; // w = w * r;
            w /= r; // w = w / r;
            w %= r; // w = w % r;
            //unary operator
            ++w;
            w++;
            --w;
            w--;
            Console.WriteLine(++w);//9
            Console.WriteLine(w++);//9
            Console.WriteLine(w);  //10
            //deciscion control
            //if statement
            int i = 10, j = 20;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

             if (i > j)
             {
                 Console.WriteLine("i is greater than j");
             }
             //if else statement
             if (i < j)
             {
                 Console.WriteLine("i is less than j");
             } else
             {
                 Console.WriteLine("i is equal or greater than j");
             }
             //if-else-if statement
             if (i < j)
             {
                 Console.WriteLine("i is less than j");
             }
             else if(i > j)
             {
                 Console.WriteLine("i is greater than j");
             }
             else { Console.WriteLine("i is eqaul to j"); }

             //ternary operator
             var result = i > j ? "i is greater than j" : "i is less than j";

             Console.WriteLine(result);

             //switch case statement
             int p = 3;
             switch (p)
             {
                 case 0: Console.WriteLine("Zero");
                 break;
                 case 1: Console.WriteLine("One");
                 break;
                 case 3: Console.WriteLine("Three");
                 break;
                 default: Console.WriteLine("Any other number");
                 break;
             }
           
        }
    }
}
