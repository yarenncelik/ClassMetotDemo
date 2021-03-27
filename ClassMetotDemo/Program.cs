using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 16512819;
            customer1.Name = "Oliver";
            customer1.Surname = "Anderson";

            Customer customer2 = new Customer();
            customer2.Id = 36185301;
            customer2.Name = "Harry";
            customer2.Surname = "Jones";

            Customer customer3 = new Customer();
            customer3.Id = 52179446;
            customer3.Name = "Emily";
            customer3.Surname = "Brown";

            Customer customer4 = new Customer();
            customer4.Id = 24725099;
            customer4.Name = "James";
            customer4.Surname = "Morton";


            CustomerManager customerManage = new CustomerManager();

            customerManage.ListCustomer(customer1);
            customerManage.ListCustomer(customer2);
            customerManage.ListCustomer(customer3);
            customerManage.ListCustomer(customer4);
            customerManage.AddCustomer(customer3);
            customerManage.DeleteCustomer(customer1);
        }
    }
}
