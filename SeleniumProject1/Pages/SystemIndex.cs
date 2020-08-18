using OpenQA.Selenium;
using SeleniumProject1.Base;
using SeleniumProject1.Grids;

namespace SeleniumProject1.Pages {
    public class SystemIndex {
        private IWebDriver driver;

        public SystemIndex() {
            this.driver = BaseDriver.Instance;
        }
        private IWebElement createNewButton => driver.FindElement(By.LinkText("Create New"));
        public TMSGrid TMSGrid => new TMSGrid();
        public void ClickCreateNew() {
            //click on create new button
            createNewButton.Click();
        }
    }
}
