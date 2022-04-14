using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huita
{

    public static class LocatorsForAssert
    {
        public static By DeliveryPrice { get; } = By.XPath("//td[@class='wt-p-xs-0 wt-b-xs-none wt-pt-xs-1 wt-text-right-xs wt-text-black wt-text-body-01 wt-no-wrap']//*[@class = 'currency-value']");
        
        public static By ProductPrice { get; } = By.XPath("//td[@class='wt-p-xs-0 wt-b-xs-none wt-text-right-xs wt-text-body-01 wt-text-black wt-no-wrap']//*[@class = 'currency-value']");

        public static By FinalPrice { get; } = By.XPath("//td[@class='wt-p-xs-0 wt-b-xs-none wt-text-right-xs wt-no-wrap']//*[@class = 'currency-value']");


    }
}
