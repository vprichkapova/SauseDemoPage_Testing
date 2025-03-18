
using System.Security.Cryptography.X509Certificates;
using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
   public class LoginTest: BasePageTest
    {
        [Test]
        public void TestLoginWithValidCredentials() {
            PerformLogin("standard_user", "secret_sauce");
            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "LOgin was not successfull");

        }
        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            PerformLogin("user", "invalid_password");
            var loginPage = new LoginPage(driver);
            string loginPageErrorMessage = loginPage.GetErrorMessage();
            Assert.That(loginPageErrorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "Error message is not correct");

        }
        [Test]
        public void TestLoginWithLockedOutUser()
        {
            PerformLogin("locked_out_user", "secret_sauce");
            var loginPage = new LoginPage(driver);
            string loginPageErrorMessage = loginPage.GetErrorMessage();
            Assert.That(loginPageErrorMessage, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."), "Error message is not correct");
        }

    }
}
