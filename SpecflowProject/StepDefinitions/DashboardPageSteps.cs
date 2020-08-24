using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions {
    [Binding]
    public class DashboardPageSteps {
        [Then(@"I verify '(.*)' Logged in on the Dashboard page")]
        public void ThenIVerifyLoggedInOnTheDashboardPage(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click option ""(.*)"" under Administration Drop Down on the dashboard Page")]
        public void WhenIClickOptionUnderAdministrationDropDownOnTheDashboardPage(string p0) {
            ScenarioContext.Current.Pending();
        }
    }
}
