using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismeg2
{
    internal class patient
    {
        private int patient_id;
        private string patient_name;
        private int age;
        private string doctor_name;
        private string disease;
        private long phone_no;
        private int bill_amount;






        public patient(int id, string name, int patient_age, string patient_disease, string doctor, long mobile,int bill)
        {
            patient_id = id;
            patient_name = name;
            age = patient_age;
            doctor_name = doctor;
            disease = patient_disease;
            phone_no = mobile;
            bill_amount = bill;

        }


        //PATIENT UPDATE

        public void update(int id,string  name,int age)
        {
            if(id == patient_id && name == patient_name)
            {

                Console.WriteLine("patient id" + patient_id);
            }
            else
            {
                Console.WriteLine("patient id is wrong");
            }
        }

        //PATIENT DISEASE CHECK

        public void update(string paname,string pdisease,int bill_ck)
        {
            if(paname == patient_name && pdisease == disease)
            {
                Console.WriteLine("disease" + disease);
            }
            else
            {
                Console.WriteLine("patient no disease");
            }
        }

            
            


    }
}
