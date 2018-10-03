using System;
using OzLearningHub.Controllers;

namespace OzLearningHub.Service
{
    public class Bank
    {
        public double Debit(double amount)
        {
            var bank = new FederalSavings(100.10);

            return bank.Balance - amount;


        }

        public class FederalSavings
        {
            public double Balance { get; set; }
            private string name;

            public FederalSavings(double balance)
            {
                Balance = balance;
            }

            //public int myVar;
            //public int myOtherVar;

            //public int MyProperty
            //{
            //    get
            //    {
            //        myVar = myVar +1;
            //        return myVar;
            //    }
            //    set { myVar= value};
            //}
        }
    }
}
