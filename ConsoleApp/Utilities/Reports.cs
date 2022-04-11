using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Utilities
{
    class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        private static ExtentReports extent;
        private ExtentManager()
        {
            
        }

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\Krasi\source\repos\STUK\ConsoleApp\ConsoleApp\Reports\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");

                string extentConfigPath = @"C:\Users\Krasi\source\repos\STUK\ConsoleApp\ConsoleApp\extent-config.xml";
                Console.WriteLine(extentConfigPath);
                htmlReporter.LoadConfig(extentConfigPath);
            }
            return extent;
        }
    }
}
