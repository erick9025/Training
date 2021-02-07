using Inheritance.Exercise2;
using Inheritance.Exercise3;
using NUnit.Framework;
using System;
namespace NUnitErick
{
    [TestFixture()]
    public class Test
    {
        /// <summary>
        /// Author: Erick Jiménez Rodríguez | erick9025@hotmail.com
        /// Repository URL: https://github.com/erick9025/Training
        /// </summary>
        [Test()]
        public void TestingAxosCards()
        {
            //declare and instantiate object (2 actions on a SINGLE LINE)
            AxosCreditCard card1 = new AxosCreditCard("Erick Jimenez", "4792012304560789", 50000, CardNetworks.Mastercard);

            //declare object ONLY
            AxosCreditCard card2;

            //instantiate object ONLY
            card2 = new AxosCreditCard("Dua Lipa", "4143101304560796", 999999, CardNetworks.AmericanExpress);

            card2.Deposit(1500);

            card1.PrintBalance();
            card1.BuySomething(1754.17, "ABC1234xyz", "Walmart Retail");
            card1.Withdraw(45.83);
            card1.PrintCardDetails();
            card1.BuySomething(10, "QJXR9414", "Amazon Marketplace");
            card1.PrintCardDetails();

            card2.PrintCardDetails();

            AxosCreditCard card3 = new AxosCreditCard("Lionel Messi", "4792012304560010", 999999, CardNetworks.Visa);
            Console.WriteLine("How many cards created so far: " + AxosCreditCard.cardCounter);

            card3.PrintCardDetails();
        }

        [Test()]
        public void MyCustomAirline()
        {
            Customer c1 = new Customer("ABC1234", "Erick", "Jiménez Rodríguez", Countries.MX, new DateTime(1990, 6, 25), Gender.Male, "Eduardo");
            Customer c2 = new Customer("MPX6187", "Ana", "González Rangel", Countries.MX, new DateTime(1988, 3, 8), Gender.Female, "Karen");
            Customer c3 = new Customer("QMX6179", "Dua", "Lipa", Countries.GB, new DateTime(1995, 8, 22), Gender.Female);
            Customer c4 = new Customer("HYA1252", "Kate", "Johnson", Countries.US, new DateTime(2005, 01, 01), Gender.Female);
            Customer c5 = new Customer("HYA1253", "Michael", "Johnson", Countries.US, new DateTime(2005, 01, 01), Gender.Male);

            c1.PrintPersonDetails();
            //c2.PrintPersonDetails();
            //c3.PrintPersonDetails();
            //c4.PrintPersonDetails();
            //c5.PrintPersonDetails();
            Console.WriteLine("Full name por 5th person: " + c5.GetFullName());

            Flight myFlight1 = new Flight(Airlines.Aeromexico, Airplanes.Jet123, 643, "Guadalajara", "Chicago");

            myFlight1.PrintSeatInformation(false);

            myFlight1.AssignSeat(7, c1);
            myFlight1.AssignSeat(11, c2);
            myFlight1.AssignSeat(12, c3);
            myFlight1.AssignSeat(2, c4);
            myFlight1.AssignSeat(3, c5);            

            myFlight1.PrintSeatInformation(true);
            myFlight1.PrintSeatInformation(false);

            myFlight1.PrintAllPassengersInfo();
        }
    }
}
