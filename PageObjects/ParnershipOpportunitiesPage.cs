using LiberisTestAutomation.Support;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisTestAutomation.PageObjects
{
    internal class ParnershipOpportunitiesPage
    {
        private By _headingLocator = By.XPath("//h1");

        public string GetHeading()
        {
            GenericUtil.WaitForElementVisible(_headingLocator, 60);
            return GenericUtil.GetText(_headingLocator);
        }

       
    }
}
