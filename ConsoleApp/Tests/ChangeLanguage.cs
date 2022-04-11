using ConsoleApp.Pages;
using ConsoleApp.Tests;
using NUnit.Framework;
using System;

namespace SeleniumTests

{
    public class MultiLanguages : BaseTest
    {
        [Test, Description("Change language")]
        public void Test()
        {
            LoginPage.Navigate();
            LoginPage.LogIn("hipafof109@aline9.com");
            MultiLanguages.ChangeLanguage();

            var text = MultiLanguages.LanguageCheck.Text;
            Assert.AreEqual("Notifications are disabled", text);
        }
    }
}
