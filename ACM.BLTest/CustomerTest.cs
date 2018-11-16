using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--  Arrange
            Customer customer = new Customer {FirstName = "Bilbo", LastName = "Baggins"};
            const string expected = "Baggins, Bilbo";

            //--  Act
            string actual = customer.FullName;

            //--  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer {LastName = "Baggins"};
            const string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
     
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer {LastName = "Bilbo"};
            const string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            Customer c1 = new Customer {FirstName = "Bilbo"};
            Customer.InstanceCount += 1;

            Customer c2 = new Customer {FirstName = "Frodo"};
            Customer.InstanceCount += 1;

            Customer c3 = new Customer {FirstName = "Rosie"};
            Customer.InstanceCount += 1;

            //--  Act

            //--  Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }


        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer {LastName = "Baggins", EmailAddress = "fbaggins@hobbiton.me"};

            //-- Act
            bool actual = customer.Validate();
            //-- Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer customer = new Customer {  EmailAddress = "fbaggins@hobbiton.me" };

            //-- Act
            bool actual = customer.Validate();
            //-- Assert
            Assert.IsFalse(actual);
        }

         [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //-- Arrange
            Customer customer = new Customer {LastName = "Baggins" };

            //-- Act
            bool actual = customer.Validate();
            //-- Assert
            Assert.IsFalse(actual);
        }



    }
}
