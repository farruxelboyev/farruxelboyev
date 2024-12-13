using System;

class Program
{
    static void Main()
    {
        Console.Write("10-lik sonni kiriting: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine("2-lik sanoq sistemasidagi qiymat: " + binaryNumber);
    }
}

