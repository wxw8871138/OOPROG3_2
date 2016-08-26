using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPROG3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            BankAccout2 a = new BankAccout2("001-001-001", y, 2000);
            BankAccout2 b = new BankAccout2("001-001-002", z, 5000);

            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());

        }
    }
    class Customer
    {
        private string name;
        private string address;
        private string passportNo;
        private DateTime dateOfBirth;

        public Customer(string name, string address, string passportNo, DateTime dateOfBirth)
        {
            this.name = name;
            this.address = address;
            this.passportNo = passportNo;
            this.dateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            int age = 0;
            age =  DateTime.Now.Year-dateOfBirth.Year ;
            return age;
        }
        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }
    }

    class BankAccout2
    {
        private string accountNo;
        private Customer acountHolder;
        private double balance;

        public BankAccout2(string accountNo, Customer acountHolder, double balance)
        {
            this.accountNo = accountNo;
            this.acountHolder = acountHolder;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;

        }

        public void Deposit(double amount)
        {
            balance = balance + amount;

        }

        public void TransferTo(double amount, BankAccout2 another)
        {
            balance = balance - amount;
            another.Deposit(amount);
        }

        public string Show()
        {
            string info;
            info = "address = " + acountHolder.GetAddress() + " , " + "name = " + acountHolder.GetName() + " , " + "balance = " + Convert.ToString(balance) + " , " + "age = " + Convert.ToString(acountHolder.GetAge());
            return info;
        }
    }


}
