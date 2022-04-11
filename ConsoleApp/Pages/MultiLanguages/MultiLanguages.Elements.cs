using Bogus;
using OpenQA.Selenium;


namespace ConsoleApp.Pages
{
    public partial class MultiLanguages : BasePage
    {
        public MultiLanguages(IWebDriver driver)
            : base(driver)
        {
            
        }
        public IWebElement LanguageCheck => Driver.FindElement(By.CssSelector(@"div[class='notifications-info'] > span"));
        public IWebElement ChoosingLanguage => Driver.FindElement(By.CssSelector(@"ul[class='dt-nav'] > li > a:nth-child(1)"));
        public IWebElement ChoosingEnglish => Driver.FindElement(By.CssSelector(@"div[class='dropdown-menu show'] a:nth-child(1)"));
        public IWebElement ChoosingBulgarian => Driver.FindElement(By.CssSelector(@"div[class='dropdown-menu show'] a:nth-child(2)"));


        public override void Navigate()
        {
            Driver.Url = "https://stuk.help/app/signin";
        }
    }
}
