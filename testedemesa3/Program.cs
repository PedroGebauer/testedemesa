using System;

class Programa
{
    static void Main()
    {
        int a, b;

        a = 7;
        b = a - 6;

        int[] v = new int[6];

        while (b < 6)
        {
            v[b] = b + a;
            Console.WriteLine(v[b]);
            b = b + 2;
        }
    }
}