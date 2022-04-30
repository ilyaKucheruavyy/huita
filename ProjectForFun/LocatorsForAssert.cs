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
        public static By FinalPrice { get; } = By.XPath("//h1[@class = 'wt-text-title-01']//span[@class = 'currency-value']");
    }
}
