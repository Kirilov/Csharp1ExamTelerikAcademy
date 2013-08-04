using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int dotCount = N-1;
        int dotcount2 = 0;
        int lineCount = 0;
        int indexline =2 ;
        int adder = 2;

        for (int i = 1; i <= N; i++)
        {
            Console.Write(new string('.', dotCount));
            Console.Write('/');
            if (i==indexline)
            {
                Console.Write(new string('-', dotcount2));
                indexline = indexline + adder;
                adder++;
            }
            else
            {
                Console.Write(new string('.', lineCount));
            }            
            Console.Write('\\');
            Console.Write(new string('.', dotCount));           
            Console.WriteLine();
                       
            dotCount--;
            lineCount+=2;
            dotcount2 += 2;            
        }        
    }
}

