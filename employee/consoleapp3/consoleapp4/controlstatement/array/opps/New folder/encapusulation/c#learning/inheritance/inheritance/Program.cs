using inheritance;
using System;
class Program
{
    public static void Main()
    {
        department obj1 = new department();
        obj1.student_name = "mallika";
        obj1.student_id = 21;
        obj1.student_email = "mallika@23gmail.com";
        obj1.student_phone_no = 9629555258;
        obj1.department_name = "EEE";

        obj1.student_details();



    }
}
