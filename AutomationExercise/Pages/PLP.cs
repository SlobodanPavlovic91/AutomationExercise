using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class PLP
    {
        readonly IWebDriver _driver;
        public By PLpage = By.ClassName("input-lg");
        public By SearchBar = By.Name("search");
        public By SearchBarButton = By.ClassName("btn-lg");
        

        public PLP(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(PLpage));
        }
    }
}
