using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankApp
{
    internal class Admin : UserManager
    {
        public string AdminID { get; set; } // Unique identifier for the admin
        public string Name { get; set; } // Admin's full name

        public void CreateUser() // Create new users(customer/admin/bankowner)
        {
            UserManager newUser = null; // Declared outside to maintain scope and allow assignment to different user types (Customer, Admin, SystemOwner)

            Console.WriteLine("Select user type: 1 = Customer, 2 = Admin, 3 = SystemOwner");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                newUser = new Customer();
                newUser.Role = UserManager.UserRole.Customer; 
            }
            else if (choice == 2)
            {
                newUser = new Admin();
                newUser.Role = UserManager.UserRole.Admin;
            }
            else if (choice == 3)
            {
                newUser = new SystemOwner();
                newUser.Role = UserManager.UserRole.SystemOwner;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;

            }

            Console.Write("Enter username: ");
            newUser.UserName = Console.ReadLine();
            Console.Write("Enter password: ");
            newUser.Password = Console.ReadLine();
            Console.Write("Enter email: ");
            newUser.Email = Console.ReadLine();
            Console.Write("Enter phone number: ");
            newUser.PhoneNumber = Console.ReadLine();

            UsersList.Add(newUser);
            Console.WriteLine();
        }
        public void ChangeCurrencyRates() // Update exchange rates
        {

        }

    }
}
