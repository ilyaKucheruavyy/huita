using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huita.GlobalSqa
{
    public class GlobalSqaMainPage
    {
        protected IWebDriver driver;
        public GlobalSqaMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
