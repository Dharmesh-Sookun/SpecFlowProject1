using FluentAssertions;
using SeleniumDriver;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TS03OrderSteps
    {
        private static int oldCount;
        [When(@"I add order")]
        public void WhenIAddOrder()
        {
            Order.OpenOrderPage();
            oldCount = Order.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            Order.OpenCreateOrderPage();
            Order.SelectSupplier("Carl");
            Order.SelectDate("06292021");
            Order.SelectEquipment("- Mouse - E-YOOSO");
            Order.SetQuantity(10);
            Order.SetUnitPrice(2000);
            Order.ClickAdd();
            Order.SelectEquipment("- Laptop - Lenovo P1 Gen 3");
            Order.SetQuantity(5);
            Order.SetUnitPrice(39000);
            Order.ClickAdd();
            Order.ClickCreate();
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
            int newCount = Order.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            newCount.Should().Be(oldCount + 1);
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
