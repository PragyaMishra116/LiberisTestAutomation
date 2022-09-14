using LiberisTestAutomation.Support;
using OpenQA.Selenium;


namespace LiberisTestAutomation.PageObjects
{
    internal class HomePage
    {
        private By _getADemoBtnLocator = By.XPath("//div[@class='header-cta']//a[text()='Get a demo']");
        private By _headingLocator = By.XPath("//h1");


        public string GetHeading()
        {
            return GenericUtil.GetText(_headingLocator);
        }
        public void ClickOnGetADemoBtn()
        {
            GenericUtil.ClickOnElement(_getADemoBtnLocator);
        }
    }
}
