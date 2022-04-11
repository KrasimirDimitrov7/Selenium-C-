using Bogus;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Pages
{
    public partial class ReportProblem : BasePage
    {

        public ReportProblem(IWebDriver driver)
            : base(driver)
        {
            
        }

        public IWebElement btn => Driver.FindElement(By.Id("problem-option-id"));
        public List<IWebElement> chooseProblemDescription => Driver.FindElements(By.CssSelector(@"#problem-option-id option")).ToList();
        public IWebElement detailedDescriptionOfTheProblem => Driver.FindElement(By.Id("problem-description"));
        public IWebElement browseImageBtn => Driver.FindElement(By.Id("imageUrl"));
        public List<IWebElement> informMeByBtn => Driver.FindElements(By.CssSelector(@"div[class='d - flex'] input")).ToList();
        public IWebElement reportProblemBtn => Driver.FindElement(By.CssSelector("button[class^='btn btn']"));
        public IWebElement sucsuccessfullyText => Driver.FindElement(By.CssSelector("h2#swal2-title"));



        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/024910070821";
        }
    }
}
