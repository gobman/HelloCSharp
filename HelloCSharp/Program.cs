using System;

namespace HelloCSharp
{
    //Class for main HelloCSharp
    class Program
    {
        static float Add(float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Program can work with two args (a b)");
                return;
            }
            if (args.Length == 2)
            {
                float answer = Add(float.Parse(args[0]), float.Parse(args[1]));  
                Console.WriteLine(args[0] + " + " + args[1] + " = " + answer);
            }

            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
        }
    }
}
