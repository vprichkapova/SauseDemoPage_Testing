
using OpenQA.Selenium;

namespace SauseDemoPage_Testing.Pages
{
    class InventoryPage: BasePage

    {
        public InventoryPage(IWebDriver driver) : base(driver)
        {
        }
        public readonly By productsTitle = By.XPath("//span[@class='title']");
        private readonly By cartLink = By.XPath("//a[@class='shopping_cart_link']");
        private readonly By inventoryItems = By.CssSelector("[class=inventory_item]");
        public bool IsPageLoaded() { 
        
       return GetText(productsTitle) == "Products" && driver.Url.Contains("inventory.html");
           
        }

        public void AddToCartByIndex(int itemIndex) {

            var itemAddToCartButton = By.XPath($"(//div[@class='inventory_item'])[{itemIndex}]//div//button");
            Click(itemAddToCartButton);
           
        }
        public void AddToCartByName(string name) {
            var itemToAdd = By.XPath($"//div[text()='{name}']/ancestor::div[@class='inventory_item']//button");
            Click(itemToAdd);

        }

        public void CartLink() {
            Click(cartLink);
        }

        public bool isInventoryDisplayed() { 
        return FindElements(inventoryItems).Any(); //if there is any element in the list, it will return true
        }

    }
}
