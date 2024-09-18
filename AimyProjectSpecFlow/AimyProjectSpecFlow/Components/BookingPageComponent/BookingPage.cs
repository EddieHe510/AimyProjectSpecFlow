using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static System.Collections.Specialized.BitVector32;
using System.Reflection.Emit;

namespace TestAutomationProject.Components.BookingPageComponent
{
    public class BookingPage : Hook
    {
        IWebElement bookingList => driver.FindElement(By.XPath("//div/ul/li[3]/div[@class=\"ant-menu-submenu-title\"]"));
        IWebElement bookingOption => driver.FindElement(By.XPath("//*[@href=\"/booking/class\"]"));
        IWebElement accountSearchBox => driver.FindElement(By.XPath("//div/div[2]/div/div[2]/div/span/div/div/div/ul/li/div/input[@class=\"ant-input ant-select-search__field\"]"));
        IWebElement selectFirstOption => driver.FindElement(By.XPath("//div/div[2]/span[1][@class=\"ant-typography ant-typography-secondary\"]"));
        IWebElement delectFirstAttendee => driver.FindElement(By.XPath("//li[1]/span/i[@class=\"anticon anticon-close ant-select-remove-icon\"]"));
        IWebElement delectSecondAttendee => driver.FindElement(By.XPath("//li[2]/span/i[@class=\"anticon anticon-close ant-select-remove-icon\"]"));
        IWebElement startButton => driver.FindElement(By.XPath("//div/div[4]/button[@type=\"button\"]"));
        IWebElement termList => driver.FindElement(By.XPath("//div[1]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]"));
        IWebElement newestTerm => driver.FindElement(By.XPath("//div/div/div/ul/li[last()][@class=\"ant-select-dropdown-menu-item\"]"));
        IWebElement programmeList => driver.FindElement(By.XPath("//div[2]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]"));
        IWebElement cookingOption => driver.FindElement(By.XPath("//*[@class=\"ant-select-dropdown-menu-item ant-select-dropdown-menu-item-active\"]"));
        IWebElement cookingSelectButton => driver.FindElement(By.XPath("//div[2]/div/div/div[2]/div[4]/div[2]/div/button[1][@type=\"button\"]"));
        IWebElement nextButton => driver.FindElement(By.XPath("//div[5]/div/div[2]/div/div[2]/button[@type=\"button\"]"));
        IWebElement firstAttendeeCheckbox => driver.FindElement(By.XPath("//div[1]/div[1]/div/div[2]/div/div/label/span[2]/span[@class=\"ant-typography\"]"));
        IWebElement secondAttendeeCheckbox => driver.FindElement(By.XPath("//div[2]/div[1]/div/div[2]/div/div/label/span[1][@class=\"ant-checkbox\"]"));
        
        IWebElement firstSubmitButton => driver.FindElement(By.XPath("//*[@class=\"ant-btn ant-btn-primary\"]"));
        IWebElement secondSubmitButton => driver.FindElement(By.XPath("//div/div/div[2]/button[2][@class=\"ant-btn ant-btn-primary\"]"));

        public void bookingForFirstAttendee(string accountName)
        {
            Wait.WaitToBeClickable("XPath", 5, "//div/ul/li[3]/div[@class=\"ant-menu-submenu-title\"]");
            bookingList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@href=\"/booking/class\"]");
            bookingOption.Click();
            accountSearchBox.SendKeys(accountName);

            Wait.WaitToBeClickable("XPath", 5, "//div/div[2]/span[1][@class=\"ant-typography ant-typography-secondary\"]");
            selectFirstOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//li[2]/span/i[@class=\"anticon anticon-close ant-select-remove-icon\"]");
            delectSecondAttendee.Click();

            startButton.Click();

            Wait.WaitToBeClickable("XPath", 10, "//div[1]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            termList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div/div/div/ul/li[last()][@class=\"ant-select-dropdown-menu-item\"]");
            newestTerm.Click();


            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            programmeList.Click();
            cookingOption.Click();
            cookingSelectButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[5]/div/div[2]/div/div[2]/button[@type=\"button\"]");
            nextButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[1]/div/div[2]/div/div/label/span[2]/span[@class=\"ant-typography\"]");
            firstAttendeeCheckbox.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-btn ant-btn-primary\"]");
            firstSubmitButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div/div/div[2]/button[2][@class=\"ant-btn ant-btn-primary\"]");
            secondSubmitButton.Click();
        }

        public void bookingForSecondAttendee(string accountName)
        {
            Wait.WaitToBeClickable("XPath", 5, "//div/ul/li[3]/div[@class=\"ant-menu-submenu-title\"]");
            bookingList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@href=\"/booking/class\"]");
            bookingOption.Click();
            accountSearchBox.SendKeys(accountName);

            Wait.WaitToBeClickable("XPath", 5, "//div/div[2]/span[1][@class=\"ant-typography ant-typography-secondary\"]");
            selectFirstOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//li[1]/span/i[@class=\"anticon anticon-close ant-select-remove-icon\"]");
            delectFirstAttendee.Click();

            startButton.Click();

            Wait.WaitToBeClickable("XPath", 10, "//div[1]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            termList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div/div/div/ul/li[last()][@class=\"ant-select-dropdown-menu-item\"]");
            newestTerm.Click();


            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            programmeList.Click();
            cookingOption.Click();
            cookingSelectButton.Click();


            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[1]/div/div[2]/div/div/label/span[1][@class=\"ant-checkbox\"]");
            secondAttendeeCheckbox.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-btn ant-btn-primary\"]");
            firstSubmitButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div/div/div[2]/button[2][@class=\"ant-btn ant-btn-primary\"]");
            secondSubmitButton.Click();
        }
    }
}