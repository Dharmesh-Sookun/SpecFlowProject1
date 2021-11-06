using SeleniumDriver;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class TS01StockSteps
    {
        [Given(@"that the login page is displayed")]
        public void LoginPageIsDisplayed()
        {
            BaseMethods.OpenURL();
        }

        [When(@"I log in as (.*)")]
        public void WhenILogInAs(string username)
        {
            Login.EnterUsername(username);
            //EnterPassword();
            //ClickLogin();
        }

        [When(@"I add stock")]
        [Obsolete]
        public void WhenIAddStock()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"logged out")]
        [Obsolete]
        public void WhenLoggedOut()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"stock should be displayed")]
        public void ThenStockShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I delete stock")]
        public void WhenIDeleteStock()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"stock deleted should not be displayed")]
        [Obsolete]
        public void ThenStockDeletedShouldNotBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I update stock")]
        [Obsolete]
        public void WhenIUpdateStock()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"stock should be updated")]
        [Obsolete]
        public void ThenStockShouldBeUpdated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I view stocks")]
        [Obsolete]
        public void WhenIViewStocks()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all stocks should be displayed")]
        [Obsolete]
        public void ThenAllStocksShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I view one stock")]
        [Obsolete]
        public void WhenIViewOneStock()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all details for that stock should be displayed")]
        [Obsolete]
        public void ThenAllDetailsForThatStockShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
