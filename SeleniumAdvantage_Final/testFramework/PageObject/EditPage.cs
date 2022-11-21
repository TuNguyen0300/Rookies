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

        private readonly string Element = "//*[@class='card mt-4 top-card'][1]";
        private readonly string WebTable = "//*[@id='item-3']";
        private readonly string EditButton = "//*[@id='edit-record-3']";
        private readonly string SubmitButton = "//*[@id='submit']";
        private readonly string DeleteButton = "//*[@id='delete-record-3']";
        private readonly string expectScreenElement = "https://demoqa.com/elements";
        private readonly string expectScreenWebTable = "https://demoqa.com/webtables";

        private readonly string box_firstName = "//*[@id='firstName']";
        private readonly string box_lastName = "//*[@id='lastName']";
        private readonly string box_email = "//*[@id='userEmail']";
        private readonly string box_age = "//*[@id='age']";
        private readonly string box_salary = "//*[@id='salary']";
        private readonly string box_department = "//*[@id='department']";

        private readonly string firstname = "Draco";
        private readonly string lastname = "Malfoy";
        private readonly string email = "dracomalfoy@gmail.com";
        private readonly string age = "17";
        private readonly string salary = "12001";
        private readonly string department = "Slytherin";

        public void SelectElement()
        {
            Click(Element);
        }
        public void SelectWebTable()
        {
            Click(WebTable);
        }
        public void ClickSubmit()
        {
            Click(SubmitButton);
        }
        public void ClickDelete()
        {
            Click(DeleteButton);
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
       
        public void Clear_EnterData()
        {
            FindElementByXpath(box_firstName).Clear();
            SendKeys_(box_firstName, firstname);
            FindElementByXpath(box_lastName).Clear();
            SendKeys_(box_lastName, lastname);
            FindElementByXpath(box_email).Clear();
            SendKeys_(box_email, email);
            FindElementByXpath(box_age).Clear();
            SendKeys_(box_age, age);
            FindElementByXpath(box_salary).Clear();
            SendKeys_(box_salary, salary);
            FindElementByXpath(box_department).Clear();
            SendKeys_(box_department, department);
        }

    }
}
