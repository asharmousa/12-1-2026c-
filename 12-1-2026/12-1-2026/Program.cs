using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_2026
{
    class Bank

    {
        //5 proparities
        private string coustomer_name;
        private string coustomer_id;
        private string coustomer_password;
        private string coustomer_phone;
        private double balance;


        //getter and setter 
        public string Coustomer_Name
            {
              get{ return coustomer_name; }
              set{ coustomer_name = value; }
            }
        public string Coustomer_Id
        {
            get { return coustomer_id; }
            set { coustomer_id = value; }
        }
        public string Coustomer_Password
        {
            get { return coustomer_password; }
            set { coustomer_password = value; }
        }
        public string Coustomer_phone
        {
            get { return coustomer_phone; }
            set { coustomer_phone = value; }
        }
       
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Bank(string name, string id, string password, string phone , double balance)
        {
            this.coustomer_name = name;
            this.coustomer_id = id;
            this.coustomer_password = password;
            this.coustomer_phone = phone;
            this.balance = balance;
        }
      

        //3 methodes 
        //public void Create_acount ()
        //{
            
        //    Console.Write("Enter your name : "+coustomer_name);
        //    Console.ReadLine();
        //    Console.WriteLine();
        //    Console.Write("Enter your password : " + coustomer_password);
        //    Console.ReadLine();
        //    Console.WriteLine();
        //    Console.Write("Enter your phone : " + coustomer_phone);
        //    Console.ReadLine();
        //    Console.WriteLine();
        //    balance = 0;

        //}

        public void CheckBalance()
        {
            Console.WriteLine("in your account you have :  " + balance + "JD");
        }
       public void Deposit(int amount)
        {

            balance+= amount;
            Console.WriteLine("Your current amount is :" + balance+" JD");

        }

        public void Withdraw(double amount)
        {
            Console.WriteLine();
            if (amount % 5 != 0)
            { 
                Console.WriteLine("Withdrawal amount must be a multiple of 5."); 
            } 
            else if (amount > balance) 
            { 
                Console.WriteLine("Insufficient funds. Your balance is: " + balance + " JD"); 
            } 
            else
            { 
                balance -= amount; 
                Console.WriteLine(amount + " JD withdrawn. New balance: " + balance + " JD"); 
            } 
        }
        ~Bank()
        {
            Console.WriteLine("obj deleted");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank account = new Bank("Ashar", "C123", "pass123", "0799999999", 100);
            account.CheckBalance();
            account.Deposit(50); 
            account.Withdraw(55); 
            account.Withdraw(200); 
        }
    }
}
