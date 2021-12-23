using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region maincode
            int endpoint = 100;
            for (int i=0; i<= endpoint; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FooBar");            //number is divisible by 3 and 5, print ‘FooBar'         
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Bar");               //number is divisible by 5, print ‘Bar’
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Foo");               // number is divisible by 3, print ‘Foo’
                }
                else
                {
                    Console.WriteLine(i);                   //number is not divisible by 3 or 5, print the number
                }
            }
            #endregion
        }
    }
}
