using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject1.Base {
    public class BaseDriver {
        [ThreadStatic] private static IWebDriver driver;
        public static IWebDriver Instance {
            get {
                if (driver == null) {
                    driver = new ChromeDriver();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                }

                return driver;
            }
        }
        
        public static void Dispose() {
            driver.Quit();
        }
    }
}
