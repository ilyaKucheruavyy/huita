﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class ItemPage
    {
        [FindsBy(How = How.XPath, Using = ".//button[@class = 'many__price-btn btn btn--wide btn--orange']")]
        public IWebElement CompareProductPrice { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'compare-button flex']")]
        public IWebElement AddToCompareButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'bookmark-button flex']")]
        public IWebElement AddToPersonalListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//button[@class = 'footer__btn btn btn--transparent']")]
        public IWebElement ContinueAfterAddingToCompareButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//button[@class = 'footer__btn btn btn--graphite']")]
        public IWebElement SaveAfterAddingToPersonalListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//button[@class = 'footer__btn btn btn--transparent']")]
        public IWebElement CancelAddingToPersonalListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//button[@class = 'footer__btn btn btn--transparent']")]
        public IWebElement ContinueAfterAddingToPersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'modal__footer']//a[@class = 'footer__btn btn btn--graphite']")]
        public IWebElement GoTolist { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class = 'many__price-btn btn btn--wide btn--orange']")]
        public IWebElement ComparePriceButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'price content']//div[@class = 'shop__about col-xs-12 col-xl-7 flex-column top-xs']")]
        public IWebElement ListOfStore { get; set; }
    }
}
