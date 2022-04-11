using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApp.Pages
{
    public partial class AddOperator : BasePage
    {

        public AddOperator(IWebDriver driver)
            :base (driver)
            {
               
            }

        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //public IWebElement UserNameField => Wait.Until(d => d.FindElement(By.Id("email-1")));
        public IWebElement TeamListBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-back-office-layout/main/app-navbar-vertical/div[2]/app-navigation/app-nav-vertical-group/app-nav-vertical-item[4]/a/span"));
        public IWebElement AddOperatorBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-back-office-layout/main/div/div[2]/app-contacts/div/div/div/div/app-contacts-header/a/span"));
        public IWebElement OperatorName => Driver.FindElement(By.CssSelector(@"div[class='form-group']:nth-child(1) input"));
        public IWebElement OperatorEmailField => Driver.FindElement(By.CssSelector(@"div[class='form-group']:nth-child(2) input"));
        public IWebElement OperatorPhone => Driver.FindElement(By.CssSelector(@"div[class='form-group']:nth-child(3) input"));
        public IWebElement OperatorPassword => Driver.FindElement(By.CssSelector(@"div[class='form-group']:nth-child(4) input"));
        public IWebElement SaveOperatorBtn => Driver.FindElement(By.CssSelector(@"button span"));
        public IWebElement getOperatorName => Driver.FindElement(By.XPath(@"/html/body/app-root/app-back-office-layout/main/div/div[2]/app-contacts/div/div/div/div/app-contacts-list/div/div/app-contact-list-item[1]/div[1]/div[1]/span[1]"));


        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/app/signin";
        }
    }
}
