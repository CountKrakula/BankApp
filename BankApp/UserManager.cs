using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    {
        {
            }

            {
    }


        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        }

        Console.Write("Input password: ");
        string password = Console.ReadLine();

        Console.Write("Choose role (Customer/Admin/BankOwner or C/A/B): ");
        string input = Console.ReadLine().Trim().ToLower();

        //Assigns the user a role
        UserRole role;
        switch (input)
        {
            case "customer":
            case "c":
                role = UserRole.Customer;
                break;
            case "admin":
            case "a":
                role = UserRole.Admin;
                break;
            case "bankowner":
            case "b":
                role = UserRole.BankOwner;
                break;
            default:
                Console.WriteLine("Invalid role. choose C, A or B.");
                return;
        }

        var newUser = new Dictionary<string, object>()
        {
            {"Username", username},
            {"Password", password},
            {"Role", role},
            {"Status", UserStatus.Active},
            {"FailedAttempts", 0}
        };

        users.Add(newUser);
        Console.WriteLine($" User '{username}' Created as {role}.");
    }

    // -------------------------------------------------------
    // Login
    // -------------------------------------------------------
    private void LoginUser()
    {
        Console.Clear();
        Console.WriteLine("Login");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        var user = FindUser(username);

        if (user == null)
        {
            Console.WriteLine("Username does not exist.");
            return;
        }

        if ((UserStatus)user["Status"] == UserStatus.Locked)
        {
            Console.WriteLine("Account locked due to to many faild attempts.");
            return;
        }

        //Runs login as long as the pssword is wrong
        while (true)
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if ((string)user["Password"] == password)
            {
                Console.WriteLine($"Login success {user["Username"]} ({user["Role"]}).");
                user["FailedAttempts"] = 0; // sets FailedAttempts back to 0 
                return;
            }
            else
            {
                int attempts = (int)user["FailedAttempts"] + 1;
                user["FailedAttempts"] = attempts;

                Console.WriteLine($"Wrong password ({attempts}/3).");

                if (attempts >= 3)
                {
                    user["Status"] = UserStatus.Locked;
                    Console.WriteLine("Account is locked!");
                    return;
                }
            }
        }
    }

    // -------------------------------------------------------
    // Shows all the users in the list
    // -------------------------------------------------------
    private void ShowAllUsers()
    {
        Console.Clear();
        Console.WriteLine("Registerd users:");

        if (users.Count == 0)
        {
            Console.WriteLine("(No registerd users yet.)");
            return;
        }

        foreach (var user in users)
        {
            string username = (string)user["Username"];
            string role = user["Role"].ToString();
            string status = user["Status"].ToString();
            Console.WriteLine($" - {username} ({role}) [{status}]");
        }
    }

    // -------------------------------------------------------
    // Finds the user in the list
    // -------------------------------------------------------
    private Dictionary<string, object> FindUser(string username)
    {
        foreach (var user in users)
        {
            if (string.Equals((string)user["Username"], username, StringComparison.OrdinalIgnoreCase))
                return user;
        }
        return null;
    }
}

