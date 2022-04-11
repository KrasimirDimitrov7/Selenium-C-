using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConsoleApp.Pages;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using ConsoleApp.Models;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using ConsoleApp.Utilities;

namespace ConsoleApp.Tests
{
    [TestFixture]

    public class BaseTest
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private RegistrationUser _user;
        private LoginPage _loginPage;
        private TemporaryMail _temporaryMail;
        private SeleniumHelpers _help;
        private RegistrationPage _registrationPage;
        private AddOperator _addOperator;
        private AddMachine _addMachine;
        private ReportProblem _reportProblem;
        private MultiLanguages _multiLanguages;

        //HTML Report
        //private ExtentReports extend;
        //ExtentReports report;
        //ExtentHtmlReporter htmlReporter;
        //ExtentTest test;
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        //--------//

        public IWebDriver Driver { get => _driver; set => _driver = value; }
        public WebDriverWait Wait { get => _wait; set => _wait = value; }
        public SeleniumHelpers Help { get => _help; set => _help = value; }
        public LoginPage LoginPage { get => _loginPage; set => _loginPage = value; }
        public RegistrationUser User { get => _user; set => _user = value; }
        public TemporaryMail TemporaryMail { get => _temporaryMail; set => _temporaryMail = value; }
        public RegistrationPage RegistrationPage { get => _registrationPage; set => _registrationPage = value; }
        public AddMachine AddMachine { get => _addMachine; set => _addMachine = value; }
        public AddOperator AddOperator { get => _addOperator; set => _addOperator = value; }
        public ReportProblem ReportProblem { get => _reportProblem; set => _reportProblem = value; }
        public MultiLanguages MultiLanguages { get => _multiLanguages; set => _multiLanguages = value; }




        [SetUp]

        public void SetUp()
        {
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Help = new SeleniumHelpers(Driver);
            User = UserFactory.CreateValideUser();
            LoginPage = new LoginPage(Driver);
            TemporaryMail = new TemporaryMail(Driver);
            RegistrationPage = new RegistrationPage(Driver);
            AddMachine = new AddMachine(Driver);
            AddOperator = new AddOperator(Driver);
            ReportProblem = new ReportProblem(Driver);
            MultiLanguages = new MultiLanguages(Driver);


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]

        public void CleanUp()
        {
            var name = TestContext.CurrentContext.Test.Name;
            var result = TestContext.CurrentContext.Result.Outcome;

            if (result != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var fullPath = Path.GetFullPath("..\\..\\..\\ScreenShots\\");
                screenshot.SaveAsFile(fullPath + name + ".png", ScreenshotImageFormat.Png);
            }
            test = rep.CreateTest("ApplicationTest");
            test.Log(Status.Info, "Starting the ApplicatioTest");
            test.Log(Status.Info, "In the ApplicationTest");
            test.Log(Status.Pass, "Test Passed");
            rep.Flush();
        }

        [OneTimeSetUp]

        public void InitilizeTests()
        {
            //htmlReporter.Config.Theme = Theme.Dark;
            //htmlReporter.Config.DocumentTitle = "Test Report | Krasimir";
            //htmlReporter.Config.ReportName = "Test Reporter | Krasimir";
            //extend = new ExtentReports();
            //extend.AttachReporter(htmlReporter);


            var chromeOptions = new ChromeOptions();
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]

        public void Quit()
        {
            Driver.Quit();
        }
    }
}

