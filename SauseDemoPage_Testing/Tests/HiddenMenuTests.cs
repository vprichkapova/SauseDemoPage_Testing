using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
    public class HiddenMenuTests: BasePageTest
    {
        [SetUp]
        public void SetupMethod() {

            PerformLogin("standard_user", "secret_sauce");
         
        }

        [Test]
        public void TestOpenMenu()
        {
         var hiddenMenuPage = new HiddenMenuPage(driver);
            hiddenMenuPage.ClickMenuButton();
            Assert.That(hiddenMenuPage.IsMenuOpen, Is.True);


        }
        [Test]
        public void TestLogout() {
            var hiddenMenuPage = new HiddenMenuPage(driver);
            hiddenMenuPage.ClickMenuButton();
            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
        

        }
    }
}
