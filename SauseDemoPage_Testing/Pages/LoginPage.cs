using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauseDemoPage_Testing.Pages
{
    public class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.Id("login-button");
        private readonly By errorMessage = By.XPath("//h3[@data-test='error']");

        public void TypeUsername(string username) {

            Type(usernameField, username);
        }

        public void TypePassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }
        public string GetErrorMessage() {
            return GetText(errorMessage);


        }
    }
}
