using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_BOXING_UNBOXING
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOXING

            int test = 90; //value type
            object myObject = test; // test is boxed to myObject

            Console.WriteLine(myObject.ToString());


            //UNBOXING

            int foo = 74; // Value type
            object bar = foo; // foo is boxed to bar
            int foo۲ = (int)bar; // Unboxed back to value type

            Console.WriteLine(foo۲.ToString());


            System.Console.ReadKey();
        }
    }
}
