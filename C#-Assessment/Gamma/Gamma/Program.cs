using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proasses
{
    class Customer
    {

        public string productId { get; set; }
        public string supplierId { get; set; }
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string quantity { get; set; }


    }
    class Program
    {
        static int total = 0;

        static void Main(string[] args)
        {
            int y;
            do
            {
                Console.WriteLine("Enter the choice \n\n1. Product \n2.Supplier \n3.Enter details\n4.Bill ");

                Console.Write("CHOICE: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch (choice)
                {
                    case 1:
                        Products();
                        break;


                    case 2:
                        Suppliers();
                        break;

                    case 3:
                        CustomerDetail();
                        break;

                    case 4:
                        Bill();
                        break;


                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter 1 to continue 0 to exit");
                y = int.Parse(Console.ReadLine());

            } while (y == 1);
            Console.ReadLine();

        }

        static void Products()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214XTV; database=productsel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Products";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine(" ID \t  NAME");

            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]}");
            }
            con.Close();
        }


        static void Suppliers()
        {
            Customer customer = new Customer();
            Console.WriteLine("Please Enter the selected Product Id");
            Console.Write("PRODUCT ID: ");
            customer.productId = Console.ReadLine();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214XTV; database=productsel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@productId", customer.productId);
            cmd.CommandText = "select * from Supplier where productid=@productId";

            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine(" Id \t  Name  \t Price \t Location");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]} \t\t {rdr[2]} \t\t {rdr[3]}");
            }
            con.Close();
        }

        static void CustomerDetail()
        {

            Customer customer1 = new Customer();

            Console.Write("PRODUCT ID: ");
            customer1.productId = Console.ReadLine();

            Console.Write("SUPPLIER ID: ");
            customer1.supplierId = Console.ReadLine();

            Console.Write("NAME: ");
            customer1.customerName = Console.ReadLine();
            Console.Write("QUANTITY: ");
            customer1.quantity = Console.ReadLine();

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source=IN5CG9214XTV; database=productsel; integrated security = true";
            SqlCommand cmd1 = new SqlCommand();

            cmd1.Parameters.AddWithValue("@productId", customer1.productId);
            cmd1.Parameters.AddWithValue("@supplierId", customer1.supplierId);
            cmd1.Parameters.AddWithValue("@customername", customer1.customerName);
            cmd1.Parameters.AddWithValue("@quan", customer1.quantity);
            cmd1.CommandText = "insert into Customers(customername,productid,supplierid,quan) values(@customername,@productId,@supplierId,@quan)";
            cmd1.Connection = con1;
            con1.Open();

            int rowcount = cmd1.ExecuteNonQuery();
            if (rowcount > 0)
            {
                Console.WriteLine("Added!!!");
            }


            cmd1.CommandText = "select price from Supplier where supplierid=@supplierId";
            object price = cmd1.ExecuteScalar();
            cmd1.CommandText = "select quan from Customers where customername=@customername";
            object quant = cmd1.ExecuteScalar();
            total = total + (Convert.ToInt32(price) * Convert.ToInt32(quant));

            con1.Close();
        }


        static void Bill()
        {
            Console.WriteLine("Have any coupon code");
            Console.Write("COUPON: ");
            string coupon = Convert.ToString(Console.ReadLine());
            double D;

            if (coupon == "first20")
            {
                D = Convert.ToDouble((20 / 100) * Convert.ToDouble(total));

            }
            else
            {
                D = 0;
            }
            Console.WriteLine("__________________________________\n");
            Console.WriteLine("Total price: {0}", total);
            Console.WriteLine("Discount:{0}", D);
            Double final = total - D;
            Console.WriteLine("GRAND TOTAL:{0}", final);

        }


    }
}