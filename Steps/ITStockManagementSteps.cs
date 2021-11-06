using System;
using TechTalk.SpecFlow;
using SeleniumDriver;
using FluentAssertions;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class ITStockManagementSteps
    {

        private AddNewSupplier addNewSupplier;

        public ITStockManagementSteps()
        {
            this.addNewSupplier = new AddNewSupplier();
        }

        [Given(@"I am on the add new supplier screen")]
        public void GivenIAmOnTheAddNewSupplierScreen()
        {
            this.addNewSupplier.GoToAddNewSupplierScreen();
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter the name of the supplier")]
        public void GivenIEnterTheNameOfTheSupplier()
        {
            this.addNewSupplier.EnterNameOfSupplier();
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter the phone number of the supplier")]
        public void GivenIEnterThePhoneNumberOfTheSupplier()
        {
            this.addNewSupplier.EnterPhoneNumOfSupplier();
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter the address of the supplier")]
        public void GivenIEnterTheAddressOfTheSupplier()
        {
            this.addNewSupplier.EnterAddressOfSupplier();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click create")]
        public void WhenIClickCreate()
        {
            this.addNewSupplier.ClickCreate();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see a list of all suppliers")]
        public void ThenIShouldSeeAListOfAllSuppliers()
        {
            string actualURL = this.addNewSupplier.SeeListOfSuppliers();
            string expectedURL = "https://localhost:44362/Supplier";

            actualURL.Should().Be(expectedURL);
            //ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            this.addNewSupplier.DisposeWebDriver();
        }
    }
}
