using System;
public class Romb
{
    public static void Main()
    {
        int i, j, r;

        Console.Write("\n\n");
        Console.Write("Display the pattern like romb:\n");
        Console.Write("-----------------------------------");
        Console.Write("\n\n");
        

        Console.Write("Input number of rows (half of the romb) :");
        r = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= r; i++)
        {
            for (j = 1; j <= r - i; j++)
                Console.Write(" ");
            if (r < 0)
            {
                Console.Write("write number>0:\n");
            }
            for (j = 1; j <= 2 * i - 1; j++)
              
            Console.Write("*");
            Console.Write("\n");
        }

        for (i = r - 1; i >= 1; i--)
        {
            for (j = 1; j <= r - i; j++)
                Console.Write(" ");
            for (j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            Console.Write("\n");
            
        }
    }
   
}