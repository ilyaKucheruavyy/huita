using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using huita.GlobalSqa;
using huita.Etsy;
using System.Threading;

namespace huita
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        string etsyUrl = "https://www.etsy.com/";
        string globalSqaUrl = "https://www.globalsqa.com/";

        [SetUp]
        public void BeforeTests()
        {
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterTests()
        {
            //driver.Quit();
        }

        [Test]
        public void GlobalSqaTest()
        {
            driver.Url = globalSqaUrl;

            var GlobalSqaTest = new GlobalSqaDatePickerPage(driver);

            GlobalSqaTest.GoToDatePickermenu();
            GlobalSqaTest.ChooseCorrectDate();

        }

        [Test]
        public void Etsy()
        {
            driver.Navigate().GoToUrl(etsyUrl);
            var etsySomeTests = new EtsySomeTests(driver);

            etsySomeTests.GoToFilmsMenu();
            etsySomeTests.SearchingSomeProduct();
            etsySomeTests.SortedSomeProduct();
            etsySomeTests.ChooseFilters();

            //var productPrice = driver.FindElement(LocatorsForAssert.ProductPrice);
            //var expectedProductPrice = "14.50";
            //var actualProductPrice = productPrice.Text;

            //var deliveryPrice = driver.FindElement(LocatorsForAssert.DeliveryPrice);
            //var expectedDeliveryPrice = "14.50";
            //var actualDeliveryPrice = deliveryPrice.Text;

            //var finalCost = driver.FindElement(LocatorsForAssert.FinalPrice);
            //var expectedFinalPrice = "29.00";
            //var actualFinalPrice = finalCost.Text;

            //Assert.Multiple(()=>
            //{
            //    Assert.True(expectedDeliveryPrice == actualDeliveryPrice, $"Expected delivery price: {expectedDeliveryPrice} not current actual result");
            //    Assert.True(expectedProductPrice == actualProductPrice, $"Expected product price {expectedProductPrice}, not current actual result{actualProductPrice}");
            //    Assert.True(expectedFinalPrice == actualFinalPrice, $"Expected finaly price: {expectedFinalPrice} not current actual result {actualFinalPrice}");
            //});
        }

        [Test]
        public void test()
        {
            driver.Navigate ().GoToUrl("https://www.etsy.com/search?q=%D0%BB%D0%B8%D1%81%D0%B0+%D0%B8+%D0%B3%D0%BE%D0%BD%D1%87%D0%B0%D1%8F&explicit=1&order=price_desc");

            driver.FindElement(By.CssSelector(".filter-expander")).Click();
        }
    }
}