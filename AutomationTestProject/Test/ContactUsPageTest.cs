using AutomationTestProject.Source;


namespace AutomationTestProject.Test
{
    [TestFixture]
    internal class ContactUsPageTest : BaseTest
    {

        [Test]
        public void TestContactUs()
        {
            ContactUsPage contact = new ContactUsPage(driver);

            contact.ValidateText();

            //TestData
            string firstName = "Neha";
            string lastName = "Patidar";
            string companyName = "Simpson-StrongTie";
            string email = "abc@gmail.com";
            string city = "Dallas";
            string state = "California";
            string zipcode = "75039";
            string phoneNumber = "123-456-789";
            string productConcern = "Wood Construction Connectors";
            string subject = "regarding wood construction";
            string question = "Could you please provide me with further information about the Wood Construction Connectors?";


            contact.EnterFirstName(firstName);
            contact.EnterLastName(lastName);
            contact.EnterCompanyName(companyName);
            contact.EnterEmail(email);
            contact.EnterCity(city);
            contact.EnterState(state);
            contact.EnterZipCode(zipcode);
            contact.EnterPhoneno(phoneNumber);
            contact.EnterProductConcerns(productConcern);
            contact.EnterSubject(subject);
            contact.EnterQuestions(question);


        }

    }
}
