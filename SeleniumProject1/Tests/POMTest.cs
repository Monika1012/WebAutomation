using NUnit.Framework;
using System;

namespace SeleniumProject.Tests {
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class POMTest {
        private TurnUp TurnUp { get; set; }
        [SetUp]
        public void TestSetup() {
            this.TurnUp = new TurnUp();
            TurnUp.Login("hari", "123123");
        }
        [Test]
        public void CreateTimeTest() {
            string description = "Testing" + new Random().Next(1000, 99999).ToString();
            TurnUp.DashboardPage
                .SelectFromDropDown("Administration", "Time & Materials");
            TurnUp.IndexPage
                .ClickCreateNew();
            TurnUp.EditPage
                .SelectDropDown("Time")
                .EnterCode("123123")
                .EnterPrice("2.00")
                .EnterDescription(description)
                .ClickSave();
            TurnUp.IndexPage.TMSGrid
                .ClickGoToLastPage()
                .ValidateRowAdded(description);

        }
        [Test]
        public void DeleteTimeTest() {
            string description = "Testing" + new Random().Next(1000, 99999).ToString();
            TurnUp.DashboardPage
                .SelectFromDropDown("Administration", "Time & Materials");
            TurnUp.IndexPage
                .ClickCreateNew();
            TurnUp.EditPage
                .SelectDropDown("Time")
                .EnterCode("123123")
                .EnterPrice("2.00")
                .EnterDescription(description)
                .ClickSave();
            TurnUp.IndexPage.TMSGrid
                .ClickGoToLastPage()
                .ValidateRowAdded(description)
                .ClickDelete()
                .ValidateRowDeleted(description);
        }
        [Test]
        public void EditTimeTest() {
        }
        [TearDown]
        public void TestTearDown() {
            TurnUp.Close();
        }

    }
}
