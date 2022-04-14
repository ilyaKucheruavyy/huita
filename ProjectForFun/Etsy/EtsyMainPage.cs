using OpenQA.Selenium;

namespace huita.Etsy
{
    public class EtsyMainPage
    {
        protected IWebDriver driver;
        public EtsyMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
