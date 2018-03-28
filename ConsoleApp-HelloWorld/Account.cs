using System;
using System.Collections.Generic;

namespace ConsoleApp_HelloWorld
{
    public class Account
    {
        private string _password;

        /// <summary>
        /// ID of account user
        /// </summary>
        /// <remarks>Can only assign when initilized</remarks>
        public int AccountID { get; private set; }

        /// <summary>
        /// Name of the account user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the account user
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Country user resides in
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// List of purchases by account 
        /// </summary>
        public List<Purchase> Purchases { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <remarks>Assigns ID number</remarks>
        private Account()
        {
            Random ranNum = new Random();
            AccountID = ranNum.Next(100);
            Purchases = new List<Purchase>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the account user</param>
        /// <param name="password">Password</param>
        public Account(string name, string password) : this()
        {
            Name = name;
            _password = password;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the account user</param>
        /// <param name="password">Password</param>
        /// <param name="age">Age of the account user</param>
        public Account(string name, string password, int age) : this(name, password)
        {
            Age = age;
        }

        public Account(string name, string password, int age, string country) : this(name, password, age)
        {
            Country = country;
        }

        /// <summary>
        /// Writes details of the account to console
        /// </summary>
        public void Details()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nCountry: { Country}");
        }

        /// <summary>
        /// Add purchase to list
        /// </summary>
        /// <param name="purchase">Purchase made by user</param>
        public void AddPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
        }

        /// <summary>
        /// Writes account information to console
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("- Account Information -");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine("Purchases:");
            foreach (var purchase in Purchases)
            {
                Console.WriteLine("- " + purchase.ProductName);
            }
        }
    }
}
