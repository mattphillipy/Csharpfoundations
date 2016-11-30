using System;

class Assignment4
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int UserNumber = int.Parse(Console.ReadLine());

        int Start = 1;

        int factorial = 1;
        for (int i = Start; i <= UserNumber; i++)
        {
            factorial *= Start;
        }

        while (Start <= UserNumber)
        {
            Console.WriteLine("{0}!      =       {1}", Start, factorial);
            Start = Start + 1;
            factorial *= Start;
        }

    }
}