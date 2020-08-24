using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject.Base;

namespace SeleniumProject.Pages {
    public class Dashboard {
        private IWebDriver driver;

        public Dashboard(string userName) {
            this.driver = BaseDriver.Instance;
           
        }
        public void  SelectFromDropDown(string mainMenuOption, string subMenuOption ) {
            IWebElement Admnistration = driver.FindElement(By.LinkText(mainMenuOption));
            Admnistration.Click();
            IWebElement TimeMaterial = driver.FindElement(By.LinkText(subMenuOption));
            TimeMaterial.Click();
        }
        
    }
}
