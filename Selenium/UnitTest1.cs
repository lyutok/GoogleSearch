using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
   
    public class UnitTest1
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            
        driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Category ("SeleniumSearch")]
        [Test]
        public void correctNavigation()
        {
            // Act
            Google googlepage = new Google(driver);
            googlepage.search.SendKeys("Selenium 3");
            // driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(1000);

            googlepage.searchButton.Click();
        }
    }
}
