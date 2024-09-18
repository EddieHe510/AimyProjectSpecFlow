using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Components.LoginPageComponent
{
    public class SwitchBusinessUnit: Hook
    {
        private IWebElement unitList => driver.FindElement(By.XPath("//*[contains(text(), \"hlhedison@gmail.com\")]"));
        private IWebElement demoUnit => driver.FindElement(By.XPath("//*[contains(text(), \"Aimy Demo\")]"));
        private IWebElement okButton => driver.FindElement(By.XPath("//*[@class=\"ant-btn ant-btn-primary\"]"));

        public void selectAimyDemoUnit()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"hlhedison@gmail.com\")]");
            unitList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Aimy Demo\")]");
            demoUnit.Click();

            Wait.WaitToBeClickable("XPath", 5 , "//*[@class=\"ant-btn ant-btn-primary\"]");
            okButton.Click();

            Thread.Sleep(5000);
            driver.Navigate().Refresh();
        }
    }
}
