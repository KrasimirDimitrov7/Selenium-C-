using ConsoleApp.Pages;
using ConsoleApp.Tests;
using NUnit.Framework;
using System;

namespace SeleniumTests

{
    public class AddMachine : BaseTest
    {
        
        [Test, Description("Add machine with excel file")]
        public void AddMachineWithExcelFile()
        {
            LoginPage.Navigate();
            LoginPage.LogIn("krasibalboa@abv.bg");
            //RegistrationPage.getMailAndFillinRegistrationForm();
            AddMachine.FillInMachineDataWithExel();

            var text = AddMachine.getMachineName.Text;
            Assert.AreEqual("0001name", text);
        }

        [Test, Description("Add 61 machine")]
        public void Add61Machines()
        {
            LoginPage.Navigate();
            LoginPage.LogIn("ribol39412@ailoki.com");
            //RegistrationPage.getMailAndFillinRegistrationForm();
            AddMachine.FillIn61Machines();

            var text = AddMachine.getMachineName.Text;
            Assert.AreEqual("0001name", text);
        }

        [Test, Description("Delete 61 machine")]
        public void Delete61Machines1()
        {
            LoginPage.Navigate();
            LoginPage.LogIn("ribol39412@ailoki.com");
            //RegistrationPage.getMailAndFillinRegistrationForm();
            AddMachine.Delete61Machines();

            var text = AddMachine.getMachineName.Text;
            Assert.AreEqual("0001name", text);
        }
    }
}
