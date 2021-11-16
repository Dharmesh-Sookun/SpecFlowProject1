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
        private static string newName = "Carl";

        [When(@"I add order")]
        public void WhenIAddOrder()
        {
            Order.OpenOrderPage();
            oldCount = Order.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            Order.OpenCreateOrderPage();
            Order.SelectSupplier("Carl", "//select[@id='SupplierId']");
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

        [When(@"I delete order (.*)")]
        public void WhenIDeleteOrder(int id)
        {
            Order.OpenOrderPage();
            oldCount = Order.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            Order.DeleteOrder(id);
        }


        [When(@"I update order (.*)")]
        public void WhenIUpdateOrder(int id)
        {
            Order.OpenOrderPage();
            Order.OpenEditOrderPage(id);
            Order.SelectSupplier(newName, "//select[@id='OrderProp_SupplierId']");
            Order.ClickSave("//input[@type='submit']");
        }


        [When(@"I view orders")]
        public void WhenIViewOrders()
        {
            Order.OpenOrderPage();
        }

        [When(@"I view one order (.*)")]
        public void WhenIViewOneOrder(int id)
        {
            Order.OpenOrderPage();
            Order.GetOrderDetails(id);
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
            int newCount = Order.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            newCount.Should().Be(oldCount - 1);
        }

        [Then(@"order should be updated (.*)")]
        public void ThenOrderShouldBeUpdated(int id)
        {
            Order.GetOrderDetails(id);
            string actualValue = Order.GetSupplierName();
            actualValue.Should().Be(newName);
        }


        [Then(@"all orders should be displayed")]
        public void ThenAllOrdersShouldBeDisplayed()
        {
            string currentURL = Order.GetCurrentURL();
            string expectedURL = "https://localhost:44362/Order";
            currentURL.Should().Be(expectedURL); 
        }


        [Then(@"all details for that order should be displayed (.*)")]
        public void ThenAllDetailsForThatOrderShouldBeDisplayed(int id)
        {
            string currenturl = Order.GetCurrentURL();
            string expectedurl = "https://localhost:44362/Order/Details/" + id;
            currenturl.Should().Be(expectedurl);
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            Order.DisposeDriver();
        }
    }
}
