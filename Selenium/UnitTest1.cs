using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
   
    public class UnitTest1
    {
        // Assert
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
            googlepage.searchPanel.SendKeys("Selenium 3");
            googlepage.searchButton.Click();
            googlepage.seleniumLink.Click();
            
            // Assert
            Assert.True(IsElementPresent(googlepage.seleniumClass),
                $"seleniumClass {nameof(googlepage.seleniumClass)}' is not present on the page.");

        bool IsElementPresent(IWebElement element)
        {
                 SetImplicitTimeOut(driver, 2);
            try
            {
                var result = element.Displayed;
                // SetImplicitTimeOut(driver, 10);
                return true;
            }
            catch (NoSuchElementException)
            {
               // SetImplicitTimeOut(driver, 10);
                return false;
            }
            throw new System.Exception("Unexpected exception.");
        }

            void SetImplicitTimeOut(IWebDriver driver, int timeout)
            {
                driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(timeout);
            }
        }
    }
}
