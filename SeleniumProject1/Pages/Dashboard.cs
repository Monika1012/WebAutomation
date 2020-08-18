using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject1.Base;

namespace SeleniumProject1.Pages {
    public class Dashboard {
        private IWebDriver driver;

        public Dashboard(string userName) {
            this.driver = BaseDriver.Instance;
            IWebElement helloHari = driver.FindElement(By.CssSelector("form ul li.dropdown a.dropdown-toggle"));
            Assert.True(helloHari.Text == $"Hello {userName}!", "User could not login");
        }
        public void  SelectFromDropDown(string mainMenuOption, string subMenuOption ) {
            IWebElement Admnistration = driver.FindElement(By.LinkText(mainMenuOption));
            Admnistration.Click();
            IWebElement TimeMaterial = driver.FindElement(By.LinkText(subMenuOption));
            TimeMaterial.Click();
        }
    }
}
