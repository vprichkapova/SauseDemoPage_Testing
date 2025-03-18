

using SauseDemoPage_Testing.Pages;

namespace SauseDemoPage_Testing.Tests
{
    public class CheckoutTests : BasePageTest
    {
        [SetUp]
        public void SetupCheckOut() {

            PerformLogin("standard_user", "secret_sauce");
            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.CartLink();

            var cartPage = new CartPage(driver);
            cartPage.ClickCheckoutButton();

        }

        [Test]
        public void TestCheckoutPageLoaded() {
            var checkoutPage = new CheckoutPage(driver);
            Assert.That(checkoutPage.IsPageLoaded(), Is.True, "Checkout page is not loaded");
        }
        [Test]
        public void TestContinueToNextStep() {

            var checkoutPage = new CheckoutPage(driver);
           checkoutPage.FillOrderDetails();

            Assert.That(checkoutPage.isSecondStepLoaded(), Is.True);
        }
        [Test]
        public void TestCompleteOrder()
        {
            var checkoutPage = new CheckoutPage(driver);
            checkoutPage.FillOrderDetails();
            checkoutPage.ClickFinishButton();
            Assert.That(checkoutPage.isCheckOutCompleted(), Is.True);

        }
    }
}
