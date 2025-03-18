using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauseDemoPage_Testing.Pages
{
    public class CartPage: BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        private readonly By cartItem = By.XPath("//div[@class='cart_item']");
        private readonly By checkoutButton = By.XPath("//button[@id='checkout']");

        public bool isCartItemDisplayed()
        {
            return FindElement(cartItem).Displayed; ;
        }
        public void ClickCheckoutButton()
        {
            Click(checkoutButton);
        }

    }
}
