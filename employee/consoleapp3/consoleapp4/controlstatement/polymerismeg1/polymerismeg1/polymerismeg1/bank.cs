using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace polymerismeg1
{
    internal class bank


    {
        private long account_no;
        private string IFSC_code;
        private string accountholder_name;
        private long phone_no;
        private int initial_amount;
        private int atm_pin;

        public void deposit(long acc_no, string IFSC,string name,long mobile,int amount,int pin)
        {
            account_no = acc_no;
            IFSC_code = IFSC;
            accountholder_name = name;
            phone_no = mobile;
            initial_amount = amount;
            atm_pin = pin;

        }
        //bank transfer
        public void deposit(long acc_no,string IFSC,int amount)
        {
            if(acc_no == account_no && IFSC == IFSC_code)

            {
                initial_amount += amount;
                Console.WriteLine("bank transfer :"+initial_amount);

            }
            else
            {
                Console.WriteLine("Account No or IFSC code wrong");
            }
        }

        //ATM transfer



        public void deposit(long accno,int atmpin,int deposit)
        {


            if (accno == account_no && atmpin == atm_pin)
            {
                initial_amount += deposit;
                Console.WriteLine("ATM transfer :+initial_amount");
            }
            else
            {
                Console.WriteLine("invalid details");
            }
        
        }

        //UPI transfer
        public void deposit(string name,long mobile,int deposit_amount)
        {
            if(accountholder_name == name && phone_no == mobile)
            {
                initial_amount += deposit_amount;
                Console.WriteLine("UPI transfer : "+initial_amount);
            }
            else
            {
                Console.WriteLine("invalid UPI details");
            }
        }
            

    }
}
