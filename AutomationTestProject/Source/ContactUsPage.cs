using AutomationTestProject.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationTestProject.Source
{
    internal class ContactUsPage
    {

        private IWebDriver driver;
        public readonly PageMethods pageMethods;
        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            pageMethods = new PageMethods(driver);
        }

        
        public void ValidateText()
        {
            IWebElement searchtext = driver.FindElement(By.XPath("//p[text()='Click here to contact engineering technical support.']"));
            pageMethods.SearchText.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait.Until(driver => driver.FindElement(By.XPath("//div[@class='col-md-6']/input[@name='name']")));
        }
        public void EnterFirstName(String firstName)
        {
            pageMethods.FirstName.Clear();
            pageMethods.FirstName.SendKeys(firstName);
        }

        public void EnterLastName(String lastName)
        {
            Thread.Sleep(1000);
            pageMethods.LastName.Clear();
            pageMethods.LastName.SendKeys(lastName);
        }
        public void EnterCompanyName(String companyName)
        {
            Thread.Sleep(1000);
            pageMethods.Company.Clear();
            pageMethods.Company.SendKeys(companyName);
        }
        public void EnterEmail(String email)
        {
            Thread.Sleep(1000);
            pageMethods.Email.Clear();
            pageMethods.Email.SendKeys(email);
        }
        public void EnterCity(String city)
        {
            Thread.Sleep(1000);
            pageMethods.City.Clear();
            pageMethods.City.SendKeys(city);
        }
        public void EnterState(String state)
        {
            IWebElement dropdown = driver.FindElement(By.Id("dk2-00N1N00000PrsjN"));
            Thread.Sleep(1000);
            dropdown.Click();
            IList<IWebElement> options = dropdown.FindElements(By.XPath(".//li[contains(@class, 'dk-option')]"));

            foreach (var option in options)
            {
                if (option.Text == state)
                {
                    option.Click();
                    return; 
                }
            }

        }

        public void EnterZipCode(String zipcode)
        {
            pageMethods.Zip_code.Clear();
            pageMethods.Zip_code.SendKeys(zipcode);
        }

        public void EnterPhoneno(String phoneNumber)
        {
            pageMethods.Phone.Clear();
            pageMethods.Phone.SendKeys(phoneNumber);
        }

        public void EnterProductConcerns(String productConcern)
        {

            IWebElement dropdown = driver.FindElement(By.Id("dk3-00N1N00000PrsjP"));
            Thread.Sleep(1000);
            dropdown.Click();
            IList<IWebElement> options = dropdown.FindElements(By.XPath(".//li[contains(@class, 'dk-option')]"));

            
            foreach (var option in options)
            {
                if (option.Text == productConcern)
                {
                    
                    option.Click();
                    return; 
                }
            }

        }

        public void EnterSubject(String subject)
        {
            pageMethods.Subject.Clear();
            pageMethods.Subject.SendKeys(subject);
        }
        
        public void EnterQuestions(String questions)
        {
            pageMethods.Questions.Clear();
            pageMethods.Questions.SendKeys(questions);
            Thread.Sleep(5000);
        }

    }
}
