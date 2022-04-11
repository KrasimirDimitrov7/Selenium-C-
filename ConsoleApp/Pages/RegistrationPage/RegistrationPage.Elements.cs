using Bogus;
using OpenQA.Selenium;


namespace ConsoleApp.Pages
{
    public partial class RegistrationPage : BasePage
    {

        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
            
        }

        public IWebElement RegistrationBtn => Driver.FindElement(By.CssSelector(@"span a")); 
        public IWebElement NameField => Driver.FindElement(By.Id(@"user-name"));
        public IWebElement Company => Driver.FindElement(By.Id(@"company"));
        public IWebElement Language => Driver.FindElement(By.CssSelector(@"#language :first-child"));
        public IWebElement Email=> Driver.FindElement(By.Id(@"email-1"));
        public IWebElement Phone => Driver.FindElement(By.Id(@"phone"));
        public IWebElement Password => Driver.FindElement(By.Id(@"password-1"));
        public IWebElement CofirmPassword => Driver.FindElement(By.Id(@"password-2"));
        public IWebElement RegisterSubmit => Driver.FindElement(By.CssSelector(@"div button"));


        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/app/signin";
        }
    }
}
