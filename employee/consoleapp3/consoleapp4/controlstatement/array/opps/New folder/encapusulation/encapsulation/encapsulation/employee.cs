using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace encapsulation_using_constructor
{
    internal class employee
    {
        private int employee_id;
        private string employee_name;
        private string employee_email;
        private string employee_dep;

        public employee(int id,string name,string email,string dep)
        {
            employee_id = id;
            employee_name = name;
            employee_email = email;
            employee_dep = dep;
        }


        public void employee_details()
        {
            Console.WriteLine(employee_id);
            Console.WriteLine(employee_name);
            Console.WriteLine(employee_email);
            Console.WriteLine(employee_dep);


        }


    }
}
