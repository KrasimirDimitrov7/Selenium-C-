
using OpenQA.Selenium;

namespace ConsoleApp.Pages
{
    
    public partial class AddOperator
    {

        public void FillInOperatorData(string email)
        {
            var temporaryEmail = new TemporaryMail(Driver);
            var login = new LoginPage(Driver);

            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            TeamListBtn.Click();
            AddOperatorBtn.Click();
            OperatorName.SendKeys("Test");
            OperatorEmailField.SendKeys(email);
            OperatorPhone.SendKeys("0999999999");
            OperatorPassword.SendKeys("00000000");
            SaveOperatorBtn.Click();
            login.LogOut();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            temporaryEmail.confirmationEmail();
            Driver.SwitchTo().Window(Driver.WindowHandles[2]);
        }
    }
}
