

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
    public class BasePageTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            driver = new ChromeDriver(chromeOptions);

            driver.Manage().Window.Maximize();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
        protected void PerformLogin(string username, string password) { 
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            var loginPage = new LoginPage(driver);
            loginPage.TypeUsername(username);
            loginPage.TypePassword(password);
            loginPage.ClickLoginButton();

        }
    }
}
