using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFrame.DriverCore
{
    internal class WebDriverAction
    {
        public IWebDriver driver;

        public WebDriverAction(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By ByXpath(String locator)
        {
            return By.XPath(locator);
        }
        public string getTitle()
        {
            return driver.Title;
        }
        public IWebElement FindElementByXpath(string locator)
        {
            IWebElement e = driver.FindElement(ByXpath(locator));
            highlightElement(e);
            return e;
        }
        public IList<IWebElement> FindElementsByXpath(string locator)
        {
            return driver.FindElements(ByXpath(locator));
        }

        public IWebElement highlightElement (IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].style.border='2px solid red'", element);
            return element;
        }

        public void Click(IWebElement e)
        {
            try
            {
                highlightElement(e);
                e.Click();
                TestContext.WriteLine("click into element " + e.ToString + " passed");
            }
            catch (Exception ex)
            {
                throw ex;
                TestContext.WriteLine("click into element " + e.ToString + " failed");
            }
        }

        public void Click(string locator)
        {
            try
            {
                FindElementByXpath(locator).Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SendKeys_(string locator, string key)
        {
            try
            {
                FindElementByXpath(locator).SendKeys(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
