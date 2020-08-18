using SeleniumProject1.Base;
using SeleniumProject1.Pages;

namespace SeleniumProject1 {
    public class TurnUp {
        public TurnUp() {

        }
        private string userName;
        public void Login(string userName, string password) {
            this.userName = userName;
            GoTo("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            Login LoginPage = new Login();
            
            LoginPage
                .EnterUserName(userName)
                .EnterPassword(password)
                .ClickLogin();
        }
        private void GoTo(string url) {
            BaseDriver.Instance.Manage().Window.Maximize();
            BaseDriver.Instance.Navigate().GoToUrl(url);
        }
        
        public Dashboard DashboardPage => new Dashboard(this.userName);
        public SystemIndex IndexPage => new SystemIndex();
        public Edit EditPage => new Edit();

        public void Close() {
            BaseDriver.Dispose();
        }
    }

}
