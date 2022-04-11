using ConsoleApp.Pages;
using ConsoleApp.Tests;
using NUnit.Framework;
using System;

namespace SeleniumTests

{
    public class AddOperator : BaseTest
    {
        [Test, Description("Add operator and Login as an operator")]
        public void addOperatorAndLoginAsAnOperator()
        {
            LoginPage.Navigate();
            LoginPage.LogIn("hipafof109@aline9.com");
            var email = TemporaryMail.getMail();
            AddOperator.FillInOperatorData(email);
            LoginPage.LogIn(email);

            var text = LoginPage.NameUser.Text;
            Assert.AreEqual("test", text);
        }
    }
}
