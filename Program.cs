using System;

namespace refParm
{
    class Program
    {
          public static void method(ref int refParm, int valParam){
            refParm+=12;
            valParam+=10;
        }
        static void Main(string [] args)
        {
            int i = 0, j=0;
            method(ref i,j);
            Console.WriteLine("i={0}, j={1}", i,j);
        }
    }
}
