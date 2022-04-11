using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApp.Pages
{
    public partial class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver)
            :base (driver)
            {
               
            }

        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        public IWebElement UserNameField => Wait.Until(d => d.FindElement(By.Id("email-1")));
        public IWebElement PasswordField => Driver.FindElement(By.Id("password-1"));
        public IWebElement SubmitBtn => Driver.FindElement(By.CssSelector(@"div .form-group > button"));
        public IWebElement NameUser => Driver.FindElement(By.CssSelector(@"span .dt-avatar-name"));
        public IWebElement UserProfile => Driver.FindElement(By.CssSelector(@"span[class='dt-avatar-name']"));
        public IWebElement LogOutBtn => Wait.Until(d => d.FindElement(By.CssSelector("div[class='col-lg-8'] div [class^='d-block']:nth-child(1)")));



        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/app/signin";
        }
    }
}
