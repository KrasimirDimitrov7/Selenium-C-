using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApp.Pages
{
    public partial class AddMachine : BasePage
    {

        public AddMachine(IWebDriver driver)
            :base (driver)
            {
               
            }

        private WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //public IWebElement UserNameField => Wait.Until(d => d.FindElement(By.Id("email-1")));
        public IWebElement MachinesBtn => Wait.Until(d => d.FindElement(By.CssSelector("app-nav-vertical-group > app-nav-vertical-item:nth-child(4)  a[class^='dt-side-nav']")));
        public IWebElement AddMachineBtn => Wait.Until(d => d.FindElement(By.CssSelector(@"app-machines-list > div > button")));
        public IWebElement MachineName => Driver.FindElement(By.Id(@"name"));
        public IWebElement MachineLocation => Driver.FindElement(By.Id(@"location"));
        public IWebElement MachineDescription => Driver.FindElement(By.Id(@"description"));
        public IWebElement AddMachineBtnInPopUp => Driver.FindElement(By.XPath(@"/html/body/ngb-modal-window/div/div/app-add-machine/div[2]/div/div/form/div[2]/button"));
        public IWebElement getMachineName => Driver.FindElement(By.XPath(@"/html/body/app-root/app-back-office-layout/main/div/div[2]/app-machines-list/div/form/div[2]/table/tbody/tr[1]/td[3]/ngb-highlight"));
        public IWebElement DelеteMachineTrashIcon => Wait.Until(d => d.FindElement(By.CssSelector(@"table[class$='bordered table-hover'] tbody tr:nth-child(1) td:last-child span:nth-child(3) gx-icon")));
        public IWebElement DeleteMachineBtn => Wait.Until(d => d.FindElement(By.CssSelector(@"div[class='swal2-actions'] button:first-child")));



        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/app/signin";
        }
    }
}
