namespace BankApp
{
    internal class Program
    {
        
        static List<User> users = new List<User>();
        static List<Account> accounts = new List<Account>();
        static List<Transaction> transactions = new List<Transaction>();
        static List<Loan> loans = new List<Loan>();
        static List<CurrencyRate> rates = new List<CurrencyRate>();

        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Bank App Main Menu ---");
                Console.WriteLine("1. Login as Bank Owner");
                Console.WriteLine("2. Login as Admin");
                Console.WriteLine("3. Login as Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowBankOwnerMenu();
                        break;
                    case "2":
                        ShowAdminMenu();
                        break;
                    case "3":
                        ShowCustomerMenu();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void ShowCustomerMenu()
        {
            Customer customer = new Customer();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Customer Menu ---");
                Console.WriteLine("1. View Accounts");
                Console.WriteLine("2. Transfer Funds");
                Console.WriteLine("3. Open New Account");
                Console.WriteLine("4. Request Loan");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Viewing accounts...");
                        foreach (var account in customer.Accounts) // Placeholder for actual accounts
                        {
                            Console.WriteLine($"Account: {account.AccountNumber}, Balance: {account.Balance}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Transferring funds...");
                        customer.TransferFunds(null, null, 0); // Placeholder accounts and amount
                        break;
                    case "3":
                        Console.WriteLine("Opening account...");
                        customer.OpenAccount(new List<Account>(), "123456", "ownerID", "My Account", 100); // Placeholder values
                        break;
                    case "4":
                        Console.WriteLine("Requesting loan...");
                        customer.RequestLoan(1000); // Placeholder amount
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void ShowBankOwnerMenu()
        {
            BankOwner bankOwner = new BankOwner();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Bank Owner Menu ---");
                Console.WriteLine("1. View All Accounts");
                Console.WriteLine("2. View All Transactions");
                Console.WriteLine("3. Set Loan Policy");
                Console.WriteLine("4. Set Transfer Delay Policy");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Viewing all accounts...");
                        bankOwner.ViewAllAccounts(null); // Placeholder for actual accounts
                        break;
                    case "2":
                        Console.WriteLine("Viewing all transactions...");
                        bankOwner.ViewAllTranscations(null); // Placeholder for actual transactions
                        break;
                    case "3":
                        Console.WriteLine("Setting loan policy...");
                        bankOwner.SetLoanPolicy(5); // Placeholder multiplier
                        break;
                    case "4":
                        Console.WriteLine("Setting transfer delay policy...");
                        bankOwner.SetTransferDelayPolicy();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void ShowAdminMenu()
        {
            Admin admin = new Admin();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Update Currency Rate");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Creating User...");
                        admin.CreateUser(new List<User>(), "userID", "userName", "password", User.UserRole.Customer, "email", "phoneNumber");
                        break;
                    case "2":
                        Console.WriteLine("Updating Currency Rate...");
                        admin.UpdateCurrencyRate(null, 0);
                        break;
                    case "3":
                        running = false; 
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

    }
}
