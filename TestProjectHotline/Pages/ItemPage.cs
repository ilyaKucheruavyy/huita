using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectHotline.Pages
{
    public class ItemPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'title']")]
        public IWebElement ItemPageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'compare-button flex']")]
        public IWebElement AddToCompareButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'bookmark-button flex']")]
        public IWebElement HeartShapedIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//a[@class = 'footer__btn btn btn--graphite']")]
        public IWebElement GoTolist { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class = 'many__price-btn btn btn--wide btn--orange']")]
        public IWebElement ComparePriceButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'price content']//div[@class = 'shop__about col-xs-12 col-xl-7 flex-column top-xs']//a[@target]")]
        public IList<IWebElement> ListOfStore { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__title']")]
        public IWebElement ModalWindowHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'filters flex')]")]
        public IWebElement ListOfTheMarkets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//a")]
        public IWebElement GoToListFromModalWindow { get; set; }
    }
}
