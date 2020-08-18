using OpenQA.Selenium;
using SeleniumProject1.Base;
using SeleniumProject1.Utilities;

namespace SeleniumProject1.Pages {
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
