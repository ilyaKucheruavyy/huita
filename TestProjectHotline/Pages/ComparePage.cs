﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectHotline.Pages
{
    public class ComparePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item item-product']//a[@class = 'title-overflow']")]
        public IList<IWebElement> ComparedItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']/h1")]
        public IWebElement ComparsionHeader { get; set; }

        public IWebElement GetItemAddedToComparison(string productName)
        {
            return Driver.FindElement(By.XPath($".//a[@class = 'title-overflow' and contains(text(),'{productName}')]/preceding-sibling::div/i"));
        }
    }
}
