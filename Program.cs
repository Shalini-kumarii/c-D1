using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
        //------- print values from 1 to 255----------
            for(int i=1;i<=255;i++)
            {
                Console.WriteLine("values are:"+i);
            }

// 2  ---print value divisible by 3 or 5 but not both -------------
        for(int j=1;j<=100;j++)
            {
                 if((j % 3== 0) && (j %5 !=0) )
                    {
                        Console.WriteLine("value is="+j);
                    }
                    else if((j % 5== 0) && (j %3 !=0) )
                    {
                        Console.WriteLine("value is="+j);
                    }
            }
// 3 -- print fizz for 3 buzz for 5 and fizzbuzz for both

            
            for(int j=1;j<=100;j++)
            {
                if((j % 3== 0) && (j %5 !=0) )
                {
                        Console.WriteLine("Fizz");
                    }
                else if((j % 5== 0) && (j %3 !=0) )
                {
                    Console.WriteLine("Buzz");
                }
                else if((j % 3== 0) && (j %5 ==0))
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
        }
    }
}

