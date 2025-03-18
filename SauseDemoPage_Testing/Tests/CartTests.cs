using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
    public class CartTests: BasePageTest

    {
        [SetUp]
        public void SetupMethod()
        {
            PerformLogin("standard_user", "secret_sauce");
            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.CartLink();
        }
        [Test]
        public void TestCartItemIsDisplay()
        {
            var cartPage = new CartPage(driver);
            Assert.That(cartPage.isCartItemDisplayed(), Is.True, "Item is not displayed in the cart");

        }
        [Test]
        public void TestClickCheckout() {
          
            var cartPage = new CartPage(driver);
            cartPage.ClickCheckoutButton();

            var checkoutPage = new CheckoutPage(driver);
          //TODO use checkput page to make this assertion
            Assert.That(checkoutPage.IsPageLoaded(), Is.True);

        }
    }
}
