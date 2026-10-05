using System;
using polymerismeg1;
class Program

{


    public static void Main()
    {




        bank b1 = new bank(123456788319, "hdfc1617", "mallika", 9629555258, 12345678);
        bank b2 = new bank(2345678901, "hdfc1617", "hema", 9360851681, 23456782);

        b1.deposit("mallika", 9629555258, 10000);
    }
}
