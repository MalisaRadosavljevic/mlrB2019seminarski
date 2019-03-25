using System;

class Program
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        double V = r * r * Math.PI * H;
        Console.WriteLine(V);
    }
}
