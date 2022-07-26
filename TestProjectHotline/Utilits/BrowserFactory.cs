using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TestProjectHotline.Providers;

namespace TestProjectHotline.Helper
{
    public class BrowserFactory
    {
        public static WebDriver CreateLocalDriver()
        {
            switch (BrowserProvider.Browser)
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--safebrowsing-disable-download-protection");
                    chromeOptions.AddArgument("--disable-site-isolation-trials");
                    chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                    chromeOptions.AddUserProfilePreference("download.directory_upgrade", true);
                    chromeOptions.AddUserProfilePreference("safebrowsing.enabled", false);
                    chromeOptions.AddArgument("--start-maximized");
                    //options.UseSpecCompliantProtocol = false;
                    chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);

                    var driver = new ChromeDriver(@"E:/TestProjectHotline/TestProjectHotline/bin/Debug/net5.0/", chromeOptions);

                    return driver;

                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.SetPreference("browser.download.folderList", 2);
                    firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", false);
                    firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", false);
                    firefoxOptions.SetPreference("browser.helperApps.neverAsk.openFile",
                        "image/png, text/html, image/tiff, text/csv, application/zip, application/octet-stream");
                    firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "image/png, text/html, image/tiff, text/csv, application/zip, application/octet-stream");
                    return new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), firefoxOptions);

                case "internet explorer":
                    return new InternetExplorerDriver();

                case "edge":
                    return new EdgeDriver();

                default:
                    throw new Exception($"Browser type '{BrowserProvider.Browser}' was not identified");
            }
        }
    }
}