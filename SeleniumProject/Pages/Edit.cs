using OpenQA.Selenium;
using SeleniumProject.Base;
using SeleniumProject.Utilities;
using System.Linq;

namespace SeleniumProject.Pages {
    public class Edit {
        private IWebDriver driver;

        public Edit() {
            this.driver = BaseDriver.Instance;
        }

        //select Time in Dropdown
        
        private IWebElement dropDownArrow => driver.FindElement(By.CssSelector(".k-icon.k-i-arrow-s"));

        public Edit SelectDropDown(string option) {
            dropDownArrow.Click();
            IWebElement selectableElement = driver.FindElements(By.CssSelector("#TypeCode-list ul li")).First(e => e.Text == option);
            selectableElement.Click();
            return this;
        }
        public Edit EnterCode(string code) {
            //Enter  text in the code text box
            SeleniumSetMethod.EnterText(driver, "Code", code, "Id");
            return this;
        }
        public Edit EnterDescription(string description) {
            //Enter text int description
            SeleniumSetMethod.EnterText(driver, "Description", description, "Id");
            return this;
        }
        public Edit EnterPrice(string price) {
            //Enter text in price per unit
            IWebElement activateElement = driver.FindElement(By.CssSelector(".k-numeric-wrap.k-state-default.k-expand-padding"));
            activateElement.Click();
            SeleniumSetMethod.EnterText(driver, "input#Price", price, "CSS");
            return this;
        }
        public void ClickSave() {
            //click the save button
            SeleniumSetMethod.Click(driver, "SaveButton", "Id");
        }

           

            

           
    }
}
