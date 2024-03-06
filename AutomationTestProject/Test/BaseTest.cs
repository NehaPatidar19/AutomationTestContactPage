using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace AutomationTestProject.Test
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        protected void setup()
        {
            EdgeDriverService service = EdgeDriverService.CreateDefaultService(Utility.webDriverPath, "msedgedriver.exe");

            driver = new EdgeDriver(service);

            driver.Navigate().GoToUrl(Utility.NavigationURL);
            Thread.Sleep(5000);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath(Utility.AcceptCookie)).Click();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Dispose();
            Thread.Sleep(1000);
        }
    }
}
