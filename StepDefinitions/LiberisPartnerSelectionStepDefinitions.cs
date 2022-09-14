using FluentAssertions;
using LiberisTestAutomation.PageObjects;
using LiberisTestAutomation.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LiberisTestAutomation.StepDefinitions
{
    [Binding]
    internal class LiberisPartnerSelectionStepDefinitions
    {
        private HomePage? _homePage;
        private PartnerSelectionPage? _partnerSelectionPage;
        private ParnershipOpportunitiesPage? _parnershipOpportunitiesPage;


        [Given(@"I navigate to Liberis App")]
        public void GivenINavigateToLiberisApp()
        {
            
            GenericUtil.NavigateToUrl("https://www.liberis.com/");
        }


        [Given(@"I am in Home Page")]
        public void GivenIAmInHomePage()
        {           
           _homePage = new HomePage();            
        }

        [When(@"I click on Get A Demo button")]
        public void WhenIClickOnGetADemoButton()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _homePage = new HomePage();
            _homePage.ClickOnGetADemoBtn();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        [Then(@"Partner Selection Page should be displayed")]
        public void ThenPartnerSelectionPageShouldBeDisplayed()
        {
            _partnerSelectionPage = new PartnerSelectionPage();

            _partnerSelectionPage.GetTopHeader().Should().Equals("Type of partner");
        }

        [Then(@"Three Types of partners should be displayed")]
        public void ThenThreeTypesOfPartnersShouldBeDisplayed()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _partnerSelectionPage.GetPartnerTypesCount().Should().Equals(3);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        [Then(@"Partners Types should be displayed as expected ""([^""]*)""")]
        public void ThenPartnersTypesShouldBeDisplayedAsExpected(string expPartnerTypes)
        {
            List<string> expPTypes = expPartnerTypes.Split(',').ToList();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            List<string> actuaPTypes = _partnerSelectionPage.GetPartnerTypes();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
           
            Assert.True(actuaPTypes.SequenceEqual(expPTypes), "Partner Types are not displayed as expected, actual partners displayed: " + String.Join(",", actuaPTypes) + "\nExpected columns displayed: " + String.Join(",", expPTypes));
           
        }

        [When(@"I click on Get A Demo button from Partner Selection Page")]
        public void WhenIClickOnGetADemoButtonFromPartnerSelectionPage()
        {           
            _partnerSelectionPage.ClickOnGetADemoBtn();
        }

        [Then(@"Error message should be displayed as expected ""([^""]*)""")]
        public void ThenErrorMessageShouldBeDisplayedAsExpected(string expMsg)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Assert.True(_partnerSelectionPage.IsErrorMsgDisplayed() && _partnerSelectionPage.GetErrorMsg().Equals(expMsg),
                "Error message is not displayed as expected when Get A Demo button clicked without selecting a Partner Type");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }


        [Given(@"I am on Partner Selection Page")]
        public void GivenIAmOnPartnerSelectionPage()
        {
            _partnerSelectionPage = new PartnerSelectionPage();
        }

        [When(@"I select a partner ""([^""]*)""")]
        public void WhenISelectAPartner(string partnerType)
        {
            _partnerSelectionPage.SelectPartnerType(partnerType);
        }

        [Then(@"Partnership Page should be displayed with correct heading ""([^""]*)""")]
        public void ThenPartnershipPageShouldBeDisplayedWithCorrectHeading(string expHeading)
        {
            _parnershipOpportunitiesPage = new ParnershipOpportunitiesPage();
            string actualHeading = _parnershipOpportunitiesPage.GetHeading();

            Assert.True(expHeading.Equals(actualHeading), "PartnerShip Opportunities Page is not displayed with correct heading after selecting the Partner Type");
        }

    }
}
