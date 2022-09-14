using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TechTalk.SpecFlow;

namespace LiberisTestAutomation.Hooks
{
    [Binding]
    public sealed class WebHook
    {
        
        public static IWebDriver? driver;
          

        [BeforeFeature]
            public static void CreateWebDriver(FeatureContext context)
            {
              
                    var options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    options.AddArgument("--disable-notifications");
                    options.AddArgument("--no-sandbox");
                    driver = new ChromeDriver(options);
                    context["WEB_DRIVER"] = driver;

             
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();             

              
            }
        

        [AfterFeature]
        public static void AfterFeature()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            driver.Quit();           
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}