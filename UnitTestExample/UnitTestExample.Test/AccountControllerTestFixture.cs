using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;
using UnitTestExample.Abstractions;


namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
                Test,
                TestCase("abcd1234", false),
                TestCase("irf@uni-corvinus", false),
                TestCase("irf.uni-corvinus.hu", false),
                TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail (string email, bool expectedresult)
        {
           //Arrange
            var accountController = new AccountController();
          //Act
            var actualResult = accountController.ValidateEmail(email);
          //Assert
            Assert.AreEqual(expectedresult, actualResult);

        }



        [
          Test,
          TestCase("Aaaaaaaaaa", false),
          TestCase("AAAAAAAAA", false),
          TestCase("aaaaaaaaa", false),
          TestCase("aAa3", false),
          TestCase("AaAaAaAaA9", true),
      ]

        public void TestPassword(string password, bool expectedResult)
        {
            
            //Arrange
            AccountController accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
