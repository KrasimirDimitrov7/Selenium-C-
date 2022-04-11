using ConsoleApp.Pages;
using ConsoleApp.Tests;
using NUnit.Framework;

namespace SeleniumTests

{
    public class RegistrationTest : BaseTest
    {
        [Test, Description("Registration in Ticketing Software - STUK")]
        public void RegistrationInTicketingSoftwareStuk()
        {
            RegistrationPage.getMailAndFillinRegistrationForm();

            var text = LoginPage.NameUser.Text;
            Assert.AreEqual("Test", text);
        }
    }
}
