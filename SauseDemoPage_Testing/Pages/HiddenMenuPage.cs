using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauseDemoPage_Testing.Pages
{
    public class HiddenMenuPage: BasePage
    {
        public HiddenMenuPage(IWebDriver driver) : base(driver)
        {
        }
        public readonly By menuButton = By.Id("react-burger-menu-btn");
     
        private readonly By logoutLink = By.Id("logout_sidebar_link");
        

        public void ClickMenuButton()
        {
            Click(menuButton);
        }

        public void ClickLogoutButton() { 
        Click(logoutLink);
        
        }
        public bool IsMenuOpen() {

            return FindElement(logoutLink).Displayed;
        }
    }
}
