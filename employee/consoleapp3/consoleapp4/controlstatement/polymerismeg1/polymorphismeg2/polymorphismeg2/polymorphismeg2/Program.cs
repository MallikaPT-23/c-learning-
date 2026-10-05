using polymorphismeg2;
using System;
class Program
{
    public static void Main()
    {
        patient p1 = new patient(1, "mallika", 19, "fever", "hari", 9629555258, 500);
        patient p2 = new patient(2, "hema", 17, "stomachpain", "arumugam", 9360851681, 1000);
        p2.update(2, "mallika", 19);


    }
}



