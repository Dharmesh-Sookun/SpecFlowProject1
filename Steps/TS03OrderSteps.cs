using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TS03OrderSteps
    {
        [When(@"I add order")]
        public void WhenIAddOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I delete order")]
        public void WhenIDeleteOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I update order")]
        public void WhenIUpdateOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I view orders")]
        public void WhenIViewOrders()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I view one order")]
        public void WhenIViewOneOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"order should be displayed")]
        public void ThenOrderShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"order deleted should not be displayed")]
        public void ThenOrderDeletedShouldNotBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"order should be updated")]
        public void ThenOrderShouldBeUpdated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all orders should be displayed")]
        public void ThenAllOrdersShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all details for that order should be displayed")]
        public void ThenAllDetailsForThatOrderShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
