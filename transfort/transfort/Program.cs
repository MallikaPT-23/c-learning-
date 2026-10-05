using abstraction_ex1;
using System;
class Program
{
    public static void Main()
    {
        Transport train = new Train();
        Transport flight = new Flight();
        flight.travel();
    }
}