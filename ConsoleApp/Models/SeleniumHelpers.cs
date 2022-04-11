using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp.Models
{
    public class SeleniumHelpers
    {
        private IWebDriver driver;
        public SeleniumHelpers(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void WaitForAjax()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript(
                        "return (window.jQuery != undefined) && (jQuery.active == 0)"));
        }
        public void WaitForLoadOriginal()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }

        public void waitWholePageToLoad()
        {
            WaitForAjax();
            WaitForLoadOriginal();
        }
    }
}