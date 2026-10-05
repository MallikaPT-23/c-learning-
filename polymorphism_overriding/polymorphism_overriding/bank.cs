using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_overriding
{
    internal class bank
    {

        private long account_no;
        private string IFSC_code;
        private string accountholder_name;
        private long phone_no;
        private int initial_amount;

        private int atm_pin;

        public bank(long acc_no,string IFSC,string name,long mobile,int amount,int pin)
        {
            account_no = acc_no;
            IFSC_code = IFSC;
            account_holder = name;
            atm_pin = pin;

        }


        public void withdraw(long accno,string IFSCcode,int withdraw_amount)
        {
            if(accno==account_no && IFSCcode==IFSC_code)
            {
                if(initial_amount<1000)
                {
                    Console.WriteLine("initial amount is below 1000 do you want to withdraw this amount : Y / N");
                    var answer = Covert.Tochar(Console.ReadLine().ToLower());
                    if(answer=='y')
                    {
                        initial_amount -= withdraw_amount;
                        Console.WriteLine("after withdraw" + initial_amount);
                        Console.WriteLine(withdraw_amount + "withdraw successfully");
                            
                    }
                    else
                    {

                    }
                }
            }
        }
        



    }
}
