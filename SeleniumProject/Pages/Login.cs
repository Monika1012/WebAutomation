using OpenQA.Selenium;
using SeleniumProject.Base;
using SeleniumProject.Utilities;

namespace SeleniumProject.Pages {
    public class Login {
        private IWebDriver driver;
        public Login() {
            this.driver = BaseDriver.Instance;
        }
        public Login EnterUserName(string username) {
            //Enter the text in Username
            SeleniumSetMethod.EnterText(driver, "UserName", username, "Id");
            return this;
        }
        public Login EnterPassword(string password) {
            // Enter the text in Password
            SeleniumSetMethod.EnterText(driver, "Password", password, "Id");
            return this;
        }
        public void ClickLogin() {
            // click the button
            SeleniumSetMethod.Click(driver, "input[type='submit']", "CSS");
        }
    }
}
