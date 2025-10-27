using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Customer : User
    {

        public List<Account> Accounts { get; set; } = new List<Account>();

        public void OpenAccount(List<Account> accounts, string accountNumber, string ownerID, string accountName, decimal initialBalance)
        {
            Account newAccount = new Account
            {
                AccountNumber = accountNumber,
                OwnerID = ownerID,
                AccountName = accountName,
                Balance = initialBalance
            };
            accounts.Add(newAccount);
        }

        public void TransferFunds(Account senderAccount, Account targetAccount, decimal amount)
        {
            if (senderAccount.Balance >= amount)
            {
                senderAccount.Balance -= amount;
                targetAccount.Balance += amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds for the transfer.");
            }
        }

        public void RequestLoan(decimal amount)
        {
            // Implementation for requesting a loan
        }
    }
}
