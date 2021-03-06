using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAutomation
{
    class AboutUsPOM
    {
        private IWebDriver driver;

        public AboutUsPOM(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        public void Goto()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com/about-us");
        }
    }
}
