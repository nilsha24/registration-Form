using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Bank_Details
{ public class Customer_Details
    { public struct Customer
        {
            public int id;
            public string name;
            public long account_no;
            public int balance;
        }
public int get_customer_id(Customer[] customer)

        {
            bool x = false;
        a:
            Console.WriteLine("Enter your customer id");
            int c_id = int.Parse(Console.ReadLine());
            foreach (var item in customer)
            {
                if (item.id == c_id)
                    x = true;
            }

            if (x == false)
            {
                Console.WriteLine("You are not a valid customer");
                goto a;
            }
            return c_id;

        }

        public void show_options(bool x, Customer customer1)
        {
            Console.WriteLine("Hi {0}", customer1.name);
            while (x)
            {
                Console.WriteLine("Press 1 to Withdraw Money\nPress 2 to Deposit Money\nPress 3 to Display your Acccount Balance");
                int task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the amount you wish to withdraw");
                            int d = int.Parse(Console.ReadLine());
                            if (d < customer1.balance)
                            {
                                customer1.balance -= d;
                                Console.WriteLine("Rs.{0} is withdrawn from your account", d);
                            }
                            else
                                Console.WriteLine("You have insufficient blance");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the amount you wish to deposit");
                            int d = int.Parse(Console.ReadLine());
                            customer1.balance += d;
                            Console.WriteLine("Rs.{0} is deposited in your account", d);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Your Account balance is Rs." + customer1.balance);
                            break;
                        }

                    default: break;

                }
                Console.WriteLine("Do you wish to perform another transaction?\nEnter yes or no");
                string s = Console.ReadLine().ToLower();
                if (s == "no")
                    x = false;
                else
                {
                    x = true;
                    Console.WriteLine("");
                }
            }

        }
    }

    class Program : Customer_Details
    { 
       static void Main(string[] args)
        {
            Customer[] customer = new Customer[5];
            customer[0].id = 1; customer[0].name = "Alpha"; customer[0].account_no = 11; customer[0].balance = 10000;
            customer[1].id = 2; customer[1].name = "Beta"; customer[1].account_no = 12; customer[1].balance = 2400000;
            customer[2].id = 3; customer[2].name = "Gamma"; customer[2].account_no = 13; customer[2].balance = 9000;
            customer[3].id = 4; customer[3].name = "Delta"; customer[3].account_no = 14; customer[3].balance =78888;
            customer[4].id = 5; customer[4].name = "Epsilon"; customer[4].account_no = 15; customer[4].balance = 100;
            bool x = true;
            Customer customer1;
            Customer_Details p = new Customer_Details();

            int c_id = p.get_customer_id(customer);

            customer1 = customer[c_id];

            p.show_options(x, customer1);

            customer[c_id] = customer1;

        }


    }

}

