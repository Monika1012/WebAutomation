using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject1.Base;
using SeleniumProject1.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SeleniumProject1.Grids {
    public class TMSGrid {
        private IWebDriver driver;
        
        public TMSGrid() {
            this.driver = BaseDriver.Instance;
        }
        private IReadOnlyList<IWebElement> allRows => this.driver.FindElements(By.CssSelector("#tmsGrid tbody tr"));
        private IWebElement interestingRow;
        private IWebElement deleteButton => interestingRow.FindElement(By.LinkText("Delete"));
        public TMSGrid ClickGoToLastPage() {
            // #tmsGrid a[title= 'Go to the last page'] --> for go to last page
            Thread.Sleep(2000);
            SeleniumSetMethod.Click(driver, " #tmsGrid a[title= 'Go to the last page']", "CSS");
            
            return this;
        }

        public TMSGrid ValidateRowAdded(string searchCriteria) {
            Assert.True(allRows.Any(e =>e.Text.Contains(searchCriteria)),"Row not added");
            interestingRow = allRows.First(e => e.Text.Contains(searchCriteria));
            return this;
        }

        public void ValidateRowDeleted(string searchCriteria) {
            Assert.True(allRows.Any(e => !e.Text.Contains(searchCriteria)), "Row not deleted");
        }
        public TMSGrid ClickDelete() {
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
