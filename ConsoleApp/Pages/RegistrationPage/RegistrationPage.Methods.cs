
namespace ConsoleApp.Pages
{
    
    public partial class RegistrationPage
    {

        public void getMailAndFillinRegistrationForm()
        {
            var temporaryMail = new TemporaryMail(Driver);
            var login = new LoginPage(Driver);

            var mail = temporaryMail.getMail();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Driver.Navigate().GoToUrl("https://stuk.help/app/signin");
            RegistrationBtn.Click();
            NameField.SendKeys("Test");
            Company.SendKeys("Test");
            Language.Click();
            Email.SendKeys(mail);
            Phone.SendKeys("0999999999");
            Password.SendKeys("00000000");
            CofirmPassword.SendKeys("00000000");
            RegisterSubmit.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            temporaryMail.confirmationEmail();
            Driver.SwitchTo().Window(Driver.WindowHandles[2]);
            login.LogIn(mail);
        }
    }
}
