using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            employee obj = new employee();

            obj.employee_id = 23;
            obj.employee_name = "mallika";
            obj.employee_email = "mallika23@gmail.com";
            obj.company_name = "microsoft";

            obj.employee_details();



        }
    }
}


