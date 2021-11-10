using FluentAssertions;
using SeleniumDriver;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TS02SupplierSteps
    {
        private static int oldCount;
        private static string newName = "Visham";

        [When(@"I add supplier")]
        public void WhenIAddSupplier()
        {
            Supplier.OpenSupplierPage();
            oldCount = Supplier.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            Supplier.OpenCreateSupplierPage();
            Supplier.EnterName("Jade");
            Supplier.EnterPhoneNo("7890123");
            Supplier.EnterAddress("Ebene");
            Supplier.ClickCreate("//input[@type='submit']");
        }

        [When(@"I delete supplier (.*)")]
        public void WhenIDeleteSupplier(int id)
        {
            Supplier.OpenSupplierPage();
            oldCount = Supplier.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            Supplier.DeleteSupplier(id);
        }

        [When(@"I update supplier (.*)")]
        public void WhenIUpdateSupplier(int id)
        {
            Supplier.OpenSupplierPage();
            Supplier.OpenEditSupplierPage(id);
            Supplier.ClearField("//input[@id='Name']");
            Supplier.EnterName(newName);
            Supplier.ClickSave("//input[@type='submit']");
        }


        [When(@"I view suppliers")]
        public void WhenIViewSuppliers()
        {
            Supplier.OpenSupplierPage();
        }

        [When(@"I view one supplier (.*)")]
        public void WhenIViewOneSupplier(int id)
        {
            Supplier.OpenSupplierPage();
            Supplier.GetSupplierDetails(id);
        }
        
        [Then(@"supplier should be displayed")]
        public void ThenSupplierShouldBeDisplayed()
        {
            Supplier.OpenSupplierPage();
            int newCount = Supplier.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            newCount.Should().Be(oldCount + 1);
        }
        
        [Then(@"supplier deleted should not be displayed")]
        public void ThenSupplierDeletedShouldNotBeDisplayed()
        {
            Supplier.OpenSupplierPage();
            int newCount = Supplier.GetNumberOfRowsInTable("//table[@class='table']/tbody/tr");
            newCount.Should().Be(oldCount - 1);
        }

        [Then(@"supplier should be updated (.*)")]
        public void ThenSupplierShouldBeUpdated(int id)
        {
            Supplier.OpenSupplierPage();
            Supplier.GetSupplierDetails(id);
            string actualValue = Supplier.GetName();
            actualValue.Should().Be(newName);
        }



        [Then(@"all suppliers should be displayed")]
        public void ThenAllSuppliersShouldBeDisplayed()
        {
            string currentURL = Supplier.GetCurrentURL();
            string expectedURL = "https://localhost:44362/Supplier";
            currentURL.Should().Be(expectedURL);
        }

        [Then(@"all details for that supplier should be displayed (.*)")]
        public void ThenAllDetailsForThatSupplierShouldBeDisplayed(int id)
        {
            string currentURL = Supplier.GetCurrentURL();
            string expectedURL = "https://localhost:44362/Supplier/Details/" + id;
            currentURL.Should().Be(expectedURL);
        }

    }
}
