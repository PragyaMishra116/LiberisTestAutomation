// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LiberisTestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("LiberisPartnerSelection", Description=@"	On navigating to the URl, Get A Demo Page should be displayed.
	Partner Selection Page should be displayed on clicking Get A Demo button
	Expected Partners options should be displayed as radio button.
	I should not be able to click on Get A Demo button, without selecting a partner
	Expected error message should be displayed if partner is not selected.
	If I select a partner then respected Partner Type Page should be displayed on clicking Get A Demo button.", SourceFile="Features\\LiberisPartnerSelection.feature", SourceLine=0)]
    public partial class LiberisPartnerSelectionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "LiberisPartnerSelection.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "LiberisPartnerSelection", @"	On navigating to the URl, Get A Demo Page should be displayed.
	Partner Selection Page should be displayed on clicking Get A Demo button
	Expected Partners options should be displayed as radio button.
	I should not be able to click on Get A Demo button, without selecting a partner
	Expected error message should be displayed if partner is not selected.
	If I select a partner then respected Partner Type Page should be displayed on clicking Get A Demo button.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ThreeTypesOfPartnersShouldBeDisplayedInPartnerSelectionPage(string partnerTypes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PartnerSelectionPageNavigationAndPartnerTypeVerification"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("partnerTypes", partnerTypes);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Three types of partners should be displayed in Partner Selection Page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.Given("I navigate to Liberis App", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
 testRunner.And("I am in Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.When("I click on Get A Demo button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("Partner Selection Page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And("Three Types of partners should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("Partners Types should be displayed as expected \"{0}\"", partnerTypes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Three types of partners should be displayed in Partner Selection Page, I\'m a Brok" +
            "er,I\'m an ISO,I\'m a Strategic Partner", new string[] {
                "PartnerSelectionPageNavigationAndPartnerTypeVerification"}, SourceLine=21)]
        public virtual void ThreeTypesOfPartnersShouldBeDisplayedInPartnerSelectionPage_ImABrokerImAnISOImAStrategicPartner()
        {
#line 12
this.ThreeTypesOfPartnersShouldBeDisplayedInPartnerSelectionPage("I\'m a Broker,I\'m an ISO,I\'m a Strategic Partner", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExpectedErrorMessageShouldBeDisplayedIfPartnerIsNotSelected_(string errorMsg, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NegativeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("errorMsg", errorMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expected error message should be displayed if partner is not selected.", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
 testRunner.Given("I am on Partner Selection Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.When("I click on Get A Demo button from Partner Selection Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then(string.Format("Error message should be displayed as expected \"{0}\"", errorMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Expected error message should be displayed if partner is not selected., Please se" +
            "lect a type of partner", new string[] {
                "NegativeTest"}, SourceLine=33)]
        public virtual void ExpectedErrorMessageShouldBeDisplayedIfPartnerIsNotSelected__PleaseSelectATypeOfPartner()
        {
#line 26
this.ExpectedErrorMessageShouldBeDisplayedIfPartnerIsNotSelected_("Please select a type of partner", ((string[])(null)));
#line hidden
        }
        
        public virtual void WhenISelectAnyPartnerAndClickOnGetADemoButtonThenIShouldBeNavigatedToTheExpectedPage(string partnerType, string pageHeading, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PositiveTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("partnerType", partnerType);
            argumentsOfScenario.Add("pageHeading", pageHeading);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I select any partner and click on Get A Demo button then I should be navigat" +
                    "ed to the expected page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
 testRunner.Given("I am on Partner Selection Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.When(string.Format("I select a partner \"{0}\"", partnerType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.And("I click on Get A Demo button from Partner Selection Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then(string.Format("Partnership Page should be displayed with correct heading \"{0}\"", pageHeading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("When I select any partner and click on Get A Demo button then I should be navigat" +
            "ed to the expected page, ISO", new string[] {
                "PositiveTest"}, SourceLine=46)]
        public virtual void WhenISelectAnyPartnerAndClickOnGetADemoButtonThenIShouldBeNavigatedToTheExpectedPage_ISO()
        {
#line 38
this.WhenISelectAnyPartnerAndClickOnGetADemoButtonThenIShouldBeNavigatedToTheExpectedPage("ISO", "Partnership Opportunities", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
