using ConsoleApp.Tests;
using NUnit.Framework;


namespace SeleniumTests

{
    public class ReportProblem : BaseTest
    {
        [Test, Description("Add problem for machine")]
        public void addProblem()
        {
            ReportProblem.Navigate();
            ReportProblem.fillInProblemReport();

            var text = ReportProblem.sucsuccessfullyText.Text;
            Assert.AreEqual("Успешно!", text);
        }
    }
}
