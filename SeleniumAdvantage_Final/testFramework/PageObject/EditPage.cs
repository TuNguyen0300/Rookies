using CoreFramework.DriverCore;
using NUnit.Framework;
using OpenQA.Selenium;

namespace testFramework.PageObject
{
    public class EditPage : WebDriverAction
    {
        public EditPage(IWebDriver? driver) : base(driver)
        {
        }

        /*private readonly By searchBox = By.XPath("//input[@id='search']");
        private readonly By searchButton = By.XPath("//*");*/
        private readonly string Element = "//*[@class='card mt-4 top-card'][1]";
        private readonly string WebTable = "//*[@id='item-3']";
        private readonly string EditButton = "//*[@id='edit-record-3']";
        private readonly string expectScreenElement = "https://demoqa.com/elements";
        private readonly string expectScreenWebTable = "https://demoqa.com/webtables";
        public void SelectElement()
        {
            Click(Element);
        }
        public void SelectWebTable()
        {
            Click(WebTable);
        }
        public void CheckDisplayElement()
        {
            CompareUrl(expectScreenElement);
        }
        public void CheckDisplayWebTable()
        {
            CompareUrl(expectScreenWebTable);
        }
        public void GoToEditScreen()
        {
            Click(EditButton);
        }

        /*public IWebElement? GetSearchBox()
        {
            return _driver?.FindElement(searchBox);
        }
        public IWebElement? GetSearchButton()
        {
            return _driver?.FindElement(searchButton);
        }

        public EditPage InputSearchBox(string keyword)
        {
            GetSearchBox()?.Clear();
            GetSearchBox()?.SendKeys(keyword);

            return this;
        }*/

    }
}
