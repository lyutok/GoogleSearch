using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class Google
    {
        public IWebDriver driver;

        public Google(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title=Search]")]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[3]/center/input[1]")]
        public IWebElement searchButton;
    }
}
