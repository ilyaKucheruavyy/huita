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

            etsySomeTests.ChooseFirstProduct();
            etsySomeTests.SelectProduct();

            var productPrice = driver.FindElement(LocatorsForAssert.FinalPrice);
            var expectedProductPrice = "175.95";
            var actualProductPrice = productPrice.Text;

            Assert.True(expectedProductPrice == actualProductPrice, $"expected finaly price: {expectedProductPrice}, not current actual price {actualProductPrice}");
        }
    }
}