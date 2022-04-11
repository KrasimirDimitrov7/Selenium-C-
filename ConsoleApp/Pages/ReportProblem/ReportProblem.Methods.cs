using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Pages
{
    public partial class ReportProblem
    {
        public void uploadFile()
        {
            browseImageBtn.SendKeys(@"C:\Users\Krasi\source\repos\STUK\ConsoleApp\ConsoleApp\Pages\FilesForUpload\problem.jpg");
        }

        public void fillInProblemReport()
        {
            //chooseProblemDescription[1].Click();
            detailedDescriptionOfTheProblem.SendKeys("The machine doesn't work");
            uploadFile();
            //informMeByBtn[1].Click();
            reportProblemBtn.Click();
        }
    }
}
