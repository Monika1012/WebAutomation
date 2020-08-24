using OpenQA.Selenium;
using SeleniumProject.Base;
using SeleniumProject.Grids;

namespace SeleniumProject.Pages {
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
