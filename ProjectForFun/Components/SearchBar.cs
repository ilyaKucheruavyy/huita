using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class SearchBar : BaseComponent
    {
        public IWebElement SearchBarByPlaceHolder(string placeholderIdentifier)
        {
            return Driver.FindElement(By.XPath($".//input[@placeholder = '{placeholderIdentifier}']"));
        }
    }
}
