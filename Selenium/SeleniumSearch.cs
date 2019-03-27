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
        public IWebElement searchPanel;

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement searchButton;

        [FindsBy(How = How.PartialLinkText, Using = "https://www.seleniumhq.org")]
        public IWebElement seleniumLink;

        [FindsBy(How = How.CssSelector, Using = "body.sectionDownload")]
        public IWebElement seleniumClass;

    }


}
