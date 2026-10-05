using System;
class Program
{
    public static void Main(string[] args)
    {
        //typecasting
        //1.implicite conversion-automative conversion
        //int->long->float->double->decimal
        //2.ecplicite coversion-manual conversion
        //decimal->double->float->long->int

        int z = 21;
        long x = z;
        Console.WriteLine(x);

        decimal a = 21.345m;
        long b = Convert.ToInt64(a);
        Console.WriteLine(b);

        decimal c = 86.5556m;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d);


        decimal e = 56.56565m;
        float f = Convert.ToSingle(e);
        Console.WriteLine(f);

        decimal g = 72.345678m;
        int h = Convert.ToInt32(g);
        Console.WriteLine(h);


    }
}
