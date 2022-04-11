using ConsoleApp.Pages;
using ConsoleApp.Tests;
using NUnit.Framework;


namespace SeleniumTests

{
    public class LogInTest : BaseTest
    {
        [Test, Description("Login Ticketing Software - STUK")]
        public void LoginTicketingSoftwareStuk() {

            LoginPage.Navigate();
            LoginPage.LogIn("krasibalboa@abv.bg");
            
            var text = LoginPage.NameUser.Text;
            Assert.AreEqual("test", text);
        }
    }
}
