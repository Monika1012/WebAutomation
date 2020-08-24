using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions {
    [Binding]
    public class IndexPageSteps {
        private readonly ScenarioContext _scenarioContext;
        [Then(@"I get routed to Index page successfully")]
        public void ThenIGetRoutedToIndexPageSuccessfully() {
            _scenarioContext.Pending();
        }

        [When(@"I click on Last Page sign")]
        public void WhenIClickOnLastPageSign() {
            _scenarioContext.Pending();
        }

        [When(@"I am able to validate the entered record\.")]
        public void WhenIAmAbleToValidateTheEnteredRecord_() {
            _scenarioContext.Pending();
        }
        [Then(@"I navigate to Index page successfully")]
        public void ThenINavigateToIndexPageSuccessfully() {
            _scenarioContext.Pending();
        }

        [When(@"I click CreateNew button")]
        public void WhenIClickCreateNewButton() {
            _scenarioContext.Pending();
        }
    }
}
