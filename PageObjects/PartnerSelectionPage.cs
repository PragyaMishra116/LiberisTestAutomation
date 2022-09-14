using LiberisTestAutomation.Support;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisTestAutomation.PageObjects
{
    internal class PartnerSelectionPage
    {
        private By _topRadioBtnLocator = By.XPath("//div[@class='radio_container']//input[@type='radio']");
        private By _radioBtnLabelsLocator = By.XPath("//div[@class='radio_container']//input[@type='radio']//following-sibling::label");
        private By _topHeaderLocator = By.XPath("//div[@class='inner-content']//h4");
        private By _getADemoBtnLocator = By.XPath("//a[contains(@class,'js-partner') and text()='Get a demo']");
        private By _errorMsgLocator = By.XPath("//div[@class='ph-error-inner']");
        private string _partnerTypeSelector = "//label[contains(text(), '{0}')]/preceding-sibling::input";
        public string GetTopHeader()
        {
            GenericUtil.WaitForElementVisible(_topHeaderLocator, 30);
            return GenericUtil.GetText(_topHeaderLocator);
        }

        public int GetPartnerTypesCount()
        {
            if (GenericUtil.GetElements(_topRadioBtnLocator) != null)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return GenericUtil.GetElements(_topRadioBtnLocator).Count;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                return 0;
            }
        }

        public List<string> GetPartnerTypes()
        {
            List<string> result = new List<string>();

            ReadOnlyCollection<IWebElement> typeElements = GenericUtil.GetElements(_radioBtnLabelsLocator);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (IWebElement e in typeElements)
            {
                GenericUtil.HighlightElement(e);
                result.Add(e.Text);
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            return result;
        }

        public void ClickOnGetADemoBtn()
        {
            GenericUtil.ClickOnElement(_getADemoBtnLocator);
        }

        public string GetErrorMsg()
        {
            GenericUtil.WaitForElementVisible(_errorMsgLocator, 30);
            return GenericUtil.GetText(_errorMsgLocator);
        }

        public bool IsErrorMsgDisplayed()
        {
            return GenericUtil.IsElementAvailable(_errorMsgLocator);
        }

        public void SelectPartnerType(string partnerType)
        {            
            GenericUtil.SelectRadioBtn(By.XPath(String.Format(_partnerTypeSelector, partnerType)));
        }
    }
}
