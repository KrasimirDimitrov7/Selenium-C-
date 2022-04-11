using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Pages
{
    public partial class TemporaryMail
    {
        public string getMail()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Driver.Navigate().GoToUrl("https://10minemail.com/en/");
            return mailField.GetAttribute("value");
        }

        public void confirmationEmail()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            ScrollToView(newEmail);
            newEmail.Click();
            confirmEmail.Click();
        }
    }
}
