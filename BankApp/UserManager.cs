using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class UserManager
    {
        // Global list of all users (Customers, Admins, SystemOwners).  
        // Declared static so every class can access or modify the same shared collection.  
        // Initialized immediately to ensure it’s ready for use when the program starts.
        public static List<UserManager> UsersList = new List<UserManager>();
        public enum UserRole
        {
            Customer, 
            Admin, 
            SystemOwner
        }

        public enum UserStatus
        {
            Active, 
            Locked, 
            Deleted
        }

        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } 

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UserStatus Status { get; set; }
    }
}
