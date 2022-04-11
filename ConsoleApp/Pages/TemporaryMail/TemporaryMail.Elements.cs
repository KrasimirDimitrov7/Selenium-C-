using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace ConsoleApp.Pages
{
    public partial class TemporaryMail : BasePage
    {

        public TemporaryMail(IWebDriver driver)
            : base(driver)
        {

        }

        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(25));
        public IWebElement mailField => Driver.FindElement(By.Id("mail"));
        public IWebElement newEmail => Wait.Until(d => d.FindElement(By.CssSelector("div[class='inbox-dataList'] li:nth-child(2) div[class='col-box hidden-xs-sm'] a")));
        public IWebElement confirmEmail => Driver.FindElement(By.CssSelector("a[rel='noopener']"));


        public override void Navigate()
        {
            Driver.Url = "https://10minemail.com/en/";
        }
    }
}