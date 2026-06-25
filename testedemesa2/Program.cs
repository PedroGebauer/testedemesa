using System;

class Programa
{
    static void Main()
    {
        int a, b, c;

        a = 10;
        b = 20;
        c = (a + b) / 2;
        c = c - 40;

        int[] v = new int[4];
        v[3] = a + b + c;

        Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        Console.WriteLine($"v[3] = {v[3]}");
    }
}