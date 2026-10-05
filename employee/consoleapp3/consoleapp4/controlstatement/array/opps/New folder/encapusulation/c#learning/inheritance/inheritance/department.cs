using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class department:student
    {
        public string department_name;


        public void student_details()
        {
            Console.WriteLine(student_id);
            Console.WriteLine(student_name);

            Console.WriteLine(student_email);

            Console.WriteLine(student_phone_no);
            Console.WriteLine(department_name);
        }
    }
}
