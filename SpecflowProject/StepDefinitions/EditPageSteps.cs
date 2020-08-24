using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions {
    [Binding]
    public class EditPageSteps {
        [Then(@"I navigate to Edit Page successfully")]
        public void ThenINavigateToEditPageSuccessfully() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" from the dropdown")]
        public void WhenIEnterFromTheDropdown(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Enter code ""(.*)""")]
        public void WhenEnterCode(int p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Enter price '(.*)'")]
        public void WhenEnterPrice(Decimal p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Enter description")]
        public void WhenEnterDescription() {
            ScenarioContext.Current.Pending();
        }

        [When(@"Save")]
        public void WhenSave() {
            ScenarioContext.Current.Pending();
        }
    }
}
