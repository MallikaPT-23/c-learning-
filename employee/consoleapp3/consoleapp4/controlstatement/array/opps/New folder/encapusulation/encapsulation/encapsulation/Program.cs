using encapsulation_using_constructor;
using System;
class Program
{
    public static void Main()
    {
        employee e1 = new employee(1, "mallika", "mallika@23gmailo.com", "aero");
        e1.employee_details();
        employee e2 = new employee(2, "hari", "hari24@gmail.com", "eee");
        e2.employee_details();
   
        
    }
}
