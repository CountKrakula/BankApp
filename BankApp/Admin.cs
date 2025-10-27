using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Admin : User
    {
        public void CreateUser(List<User> users, string userID, string userName, string password, User.UserRole role, string email, string phoneNumber)
        {
            User newUser = new User
            {
                UserID = userID,
                UserName = userName,
                Password = password,
                Role = role,
                Email = email,
                PhoneNumber = phoneNumber,
                Status = User.UserStatus.Active
            };
            users.Add(newUser);
        }
        public void UpdateCurrencyRate(CurrencyRate rate, decimal newExchangeRate)
        {
            rate.ExchangeRate = newExchangeRate;
            rate.LastUpdated = DateTime.Now;
        }


    }
}
