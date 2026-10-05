using System;
class Program
{
    public static void Main(string[] args)
    {
        int a = 1;
        long b = 288483573853;
        float c = 86.487458f;
        double d = 87.4646463;
        decimal e = 56.879857948m;
        char f = 'A';
        string name = "vimal";
        bool g = true;
        DateTime h = DateTime.Now;
        DateOnly i = new DateOnly(2006, 12, 12);
        DateOnly j = DateOnly.FromDateTime(DateTime.Now);
        TimeOnly k = TimeOnly.FromDateTime(DateTime.Now);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(name);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);




    }
}
