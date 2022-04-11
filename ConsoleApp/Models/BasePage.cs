using ConsoleApp.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        public IWebDriver Driver { get => _driver; set => _driver = value; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }


        public abstract void Navigate();

        public void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            ((IJavaScriptExecutor)Driver).ExecuteScript(js);
        }

        public void ScrollToView(IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }
    }
}



//            try
//            {
//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
//                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(.,'WELCOME :)')]")));
//                //Test Result
//                test.Log(Status.Pass, "Test Pass");

//            }

//            catch (Exception e)

//            {
//                test.Log(Status.Fail, "Test Fail");
//                throw;

//            }
