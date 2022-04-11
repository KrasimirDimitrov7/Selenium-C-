using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Pages
{
    public partial class LoginPage
    {
        public void LogIn(string email)
        { 
            UserNameField.SendKeys(email);
            PasswordField.SendKeys("00000000");
            SubmitBtn.Click();
        }

        public void LogOut()
        {
            UserProfile.Click();
            LogOutBtn.Click();
        }
    }
}
