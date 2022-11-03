using AutoTest.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;
using CoreFrame.DriverCore;

namespace AutoTest.PageObject
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver? driver) : base(driver)
        {
        }

        private readonly String tfUserName = "//input[@name='uid']";

        public void inputUserName(String Username)
        {
            SendKeys_(tfUserName, Username);
        }

        
    }
}
