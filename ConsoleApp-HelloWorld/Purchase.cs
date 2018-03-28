using System;

namespace ConsoleApp_HelloWorld
{
    public class Purchase
    {
        private int _accountID;

        /// <summary>
        /// ID of purchase
        /// </summary>
        public int PurchaseID { get; private set; }

        /// <summary>
        /// Name of purchased product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>Purchase ID is assigned</remarks>
        public Purchase(int id)
        {
            _accountID = id;
            Random ranNum = new Random();
            PurchaseID = ranNum.Next(100);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productName">Name of product</param>
        public Purchase(int id, string productName) : this(id)
        {
            ProductName = productName;
        }
    }
}
