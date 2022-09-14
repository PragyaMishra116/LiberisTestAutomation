using LiberisTestAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;


namespace LiberisTestAutomation.Support
{
    internal class GenericUtil
    {
        public static IWebDriver? driver = WebHook.driver;

        public static IWebElement? GetElement(By locator)
        {
            try
            {
                driver = WebHook.driver;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                IWebElement element = driver.FindElement(locator);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (element.Displayed)
                {

                    try
                    {
                        HighlightElement(element);
                       
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    return element;

                }
                else
                {
                    throw new ElementNotVisibleException();
                }
            }
            catch (Exception)
            {
                return null;


            }
        }


        public static IWebElement? GetHiddenElement(By locator)
        {
            try
            {
                driver = WebHook.driver;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                IWebElement element = driver.FindElement(locator);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (!element.Displayed)
                {                   
                    return element;

                }
                else
                {
                    throw new Exception("Element is not hidden");
                }
            }
            catch (Exception)
            {
                return null;


            }
        }

        public static ReadOnlyCollection<IWebElement>? GetElements(By locator)
        {
            try
            {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                ReadOnlyCollection<IWebElement> elements = driver.FindElements(locator);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (elements.Count > 0)
                {                    
                    return elements;
                }
                else
                {
                    throw new ElementNotVisibleException(null, null);
                }
            }
            catch (Exception)
            {
                return null;


            }
        }

        public static void HighlightElement(IWebElement element)
        {
            var javaScriptDriver = (IJavaScriptExecutor)driver;
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 4px; border-style: solid; border-color: green"";";
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            javaScriptDriver.ExecuteScript(highlightJavascript, new object[] { element });
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        }

        public static Boolean IsElementAvailable(By locator)
        {
            if (GetElement(locator) != null)
            {               
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ClickOnElement(By locator)
        {
            if (IsElementAvailable(locator))
            {

                IWebElement? ele = GetElement(locator);
                try
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    ele.Click();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else
            {
                throw new Exception("Element which you want to click is not available in the DOM");
            }

        }

        public static string GetText(By locator)
        {
            try
            {
              if (IsElementAvailable(locator))
                {
                    IWebElement element = GetElement(locator);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    return element.Text;
#pragma warning restore CS8602 // Dereference of a possibly null reference.


                }
                else
                {
                    throw new Exception("Element from which you want to get text, is not available in the DOM");
                }
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public static void NavigateToUrl(string url)
        {          
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            driver.Navigate().GoToUrl(url);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public static void WaitForElementVisible(By by, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }      

        public static void ClickElementWithScriptExecutor(IWebElement element)
        {
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public static void SelectRadioBtn(By locator)
        {
            IWebElement element;
          
                if (!IsRadioBtnSelected(locator))
                {
                    element = GetHiddenElement(locator);
                    try
                    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        element.Click();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    }
                    catch (Exception)
                    {
#pragma warning disable CS8604 // Possible null reference argument.
                        ClickElementWithScriptExecutor(element);
#pragma warning restore CS8604 // Possible null reference argument.
                    }
                }
        } 
        
        

        public static void UnSelectRadioBtn(By locator)
        {
            IWebElement element;            
                if (IsRadioBtnSelected(locator))
                {
                    element = GetHiddenElement(locator);
                    try
                    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        element.Click();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    }
                    catch (Exception)
                    {
#pragma warning disable CS8604 // Possible null reference argument.
                        ClickElementWithScriptExecutor(element);
#pragma warning restore CS8604 // Possible null reference argument.
                    }
                }
            }
           
        

        public static bool IsRadioBtnSelected(By locator)
        {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return GetHiddenElement(locator).Selected;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        }
    }
}
