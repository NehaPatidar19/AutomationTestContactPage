using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTestProject.PageObject
{
    public class PageMethods
    {
        private IWebDriver driver;

        public PageMethods(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = Utility.SearchText)]
        public IWebElement SearchText;

        [FindsBy(How = How.XPath, Using = Utility.FirstName)]
        public IWebElement FirstName;

        [FindsBy(How = How.XPath, Using = Utility.LastName)]
        public IWebElement LastName;

        [FindsBy(How = How.XPath, Using = Utility.Company)]
        public IWebElement Company;

        [FindsBy(How = How.XPath, Using = Utility.Email)]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = Utility.City)]
        public IWebElement City;

        [FindsBy(How = How.XPath, Using = Utility.State)]
        public IWebElement State;

        [FindsBy(How = How.XPath, Using = Utility.ZipCode)]
        public IWebElement Zip_code;

        [FindsBy(How = How.XPath, Using = Utility.Phone)]
        public IWebElement Phone;

        [FindsBy(How = How.XPath, Using = Utility.ProductConcerns)]
        public IWebElement Product_Concerns;


        [FindsBy(How = How.XPath, Using = Utility.Subject)]
        public IWebElement Subject;

        [FindsBy(How = How.XPath, Using = Utility.Questions)]
        public IWebElement Questions;
    }
}
