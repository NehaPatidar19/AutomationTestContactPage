namespace AutomationTestProject
{
    public static class Utility
    {
        public const string webDriverPath = "C:\\Users\\nehap\\ASP.NET C# Project\\AutomationTestProject\\AutomationTestProject";
        public const string NavigationURL = "https://www.strongtie.com/contact";
        public const string AcceptCookie= "//button[@id='acceptCookiePolicy']";
        public const string SearchText = "//p[text()='Click here to contact engineering technical support.']";
        public const string FirstName = "//div[@class='col-md-6']/input[@name='name']";
        public const string LastName = "//div[@class='col-md-6']/input[@name='lastname' and @type='text' and not(@id)]";
        public const string Company = "//div[@class='col-md-6']//label[text()='Company']/following-sibling::input[@name='company' and not(@id)]";
        public const string Email = "//div[@class='contactUsAccordian__heading' and contains(text(), 'Technical or Product Use Questions')]/following-sibling::div[@class='contactUsAccordian__blockContent']//input[@name='email']";
        public const string City = "//div[@class = 'contactUsAccordian__blockContent']//input[@id='00N1N00000PrsjM']";
        public const string State = "//select[@id='00N1N00000PrsjN' and @name='00N1N00000PrsjN']/";
        public const string ZipCode = "//div[@class = 'contactUsAccordian__blockContent']//input[@id='00N1N00000PrsjO']";
        public const string Phone = "//div[@class = 'contactUsAccordian__blockContent']//input[@name='phone' and not(@id)]";
        public const string ProductConcerns = "//select[@id='00N1N00000PrsjP' and @name='00N1N00000PrsjP']";
        public const string Subject = "//div[@class = 'contactUsAccordian__blockContent']//input[@name='subject']";
        public const string Questions = "//div[@class='contactUsAccordian__heading' and contains(text(), 'Technical or Product Use Questions')]/following-sibling::div[@class='contactUsAccordian__blockContent']//textarea[@class='contactUsAccordian__textArea']";
    }
}
