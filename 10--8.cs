using System;

class Program
{
    static void Main()
    {
        Console.Write("10-lik son: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // 10-likdan 8-lik sanoq sistemasiga o'tkazish
        string octalNumber = Convert.ToString(decimalNumber, 8);

        Console.WriteLine("8-lik son: " + octalNumber);
    }
}
