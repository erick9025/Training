using Inheritance.Exercise2;
using NUnit.Framework;
using System;
namespace NUnitErick
{
    [TestFixture()]
    public class Test
    {
        /// <summary>
        /// Author: Erick Jiménez Rodríguez | erick9025@hotmail.com | Guadalajara, México
        /// Repository URL: https://github.com/erick9025/Training
        /// </summary>
        [Test()]
        public void Exercise_AxosCards()
        {
            //declare and instantiate object (2 actions on a SINGLE LINE)
            AxosCreditCard card1 = new AxosCreditCard("Erick Jiménez", "5491012304560789", 50000, CardNetworks.Mastercard);

            //declare object ONLY
            AxosCreditCard card2;

            //instantiate object ONLY
            card2 = new AxosCreditCard("Dua Lipa", "4111009304560796", 999999, CardNetworks.Visa);

            card2.Deposit(1500);

            card1.PrintBalance();
            card1.BuySomething(1754.17, "ABC1234", "Walmart Retail");
            card1.BuySomething(10, "PPL9871", "Paypal Payment");
            card1.Withdraw(45.83);
            card1.PrintCardDetails();
            card1.BuySomething(300, "QJXR9414", "Amazon Marketplace");
            card1.PrintCardDetails();

            card2.PrintCardDetails();

            AxosCreditCard card3 = new AxosCreditCard("Lionel Messi", "340001230456010", 999999, CardNetworks.AmericanExpress);
            Console.WriteLine("How many cards created so far: " + AxosCreditCard.cardCounter);

            card3.AddAdditionals();
            card3.PrintCardDetails();
        }

        [Test()]
        public void PendingName()
        {
            
        }
    }
}
