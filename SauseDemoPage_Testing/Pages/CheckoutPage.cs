
using OpenQA.Selenium;

namespace SauseDemoPage_Testing.Pages
{
    class CheckoutPage: BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly By firstNameField = By.Id("first-name");
        private readonly By lastNameField = By.Id("last-name");
        private readonly By postalCodeField = By.Id("postal-code");

        private readonly By continueButton = By.Id("continue");
        private readonly By finishButton = By.Id("finish");
        private readonly By cancelButton = By.Id("cancel");
        private readonly By completionHeader = By.XPath("//h2[@class='complete-header']");

        public void TypeFirstName(string firstname) { 
            Type(firstNameField, firstname);
        }
        public void TypeLastName(string lastname)
        {
            Type(lastNameField, lastname);
        }
        public void TypePostalCode(string zipcode)
        {
            Type(postalCodeField, zipcode);

        }
        public void ClickContinueButton()
        {
            Click(continueButton);
        }
        public void ClickFinishButton()
        {
            Click(finishButton);
        }
     
       
        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") || driver.Url.Contains("checkout-step-two.html");
        }

        public bool isCheckOutCompleted() { 
        return GetText(completionHeader) == "Thank you for your order!";
        }
        public bool isSecondStepLoaded() { 
        return driver.Url.Contains("checkout-step-two.html");
        }
        public void FillOrderDetails() {
           
            TypeFirstName("John");
            TypeLastName("Doe");
            TypePostalCode("12345");
            ClickContinueButton();
        }
    }
}
