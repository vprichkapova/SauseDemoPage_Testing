using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
   public class InventoryTests: BasePageTest
    {
        [SetUp]
        public void SetupToLogin()
        {
            PerformLogin("standard_user", "secret_sauce");
        }
        [Test]
        public void TestInventoryDisplay() {
        
            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.isInventoryDisplayed(), Is.True, "Inventory is not displayed");
        }

        [Test]
        public void TestAddToCartByIndex() { 
        
            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.CartLink();

            var cartPage = new CartPage(driver);
            Assert.That(cartPage.isCartItemDisplayed(), Is.True, "Item is not displayed in the cart");

        }

        [Test]
        public void TestAddToCartByName() {

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByName("Sauce Labs Backpack");
            inventoryPage.CartLink();
          
            var cartPage = new CartPage(driver);
            Assert.That(cartPage.isCartItemDisplayed(), Is.True, "Item is not displayed in the cart");

        }

        [Test]
        public void TestPageTitle() {
            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "Page is not loaded");

        }
    }
}
