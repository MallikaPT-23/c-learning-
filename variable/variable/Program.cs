//basic syntax
using System;
using variable;
class Program
{
    public static void Main()
    {
        ////local variable
        //int a = 8;
        //int b = 5;
        //int c = 9;
        //Console.WriteLine(a);
        //Console.Write(b);
        //Console.Write(c);

        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(a);

        //object creation
        college obj = new college();
        obj.student_name = "mallika";
        obj.college_name = "ACE";
        obj.student_details();

        Console.WriteLine("------------------------------------------------------------------");
        college obj1 = new college();
        obj1.student_name = "Hema";
        obj1.college_name = "KLN";
        obj1.student_details();




    }
}
