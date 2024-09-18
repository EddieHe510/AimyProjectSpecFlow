using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace TestAutomationProject.Components.BookingPageComponent
{
    public class BookingManagerPage : Hook
    {
        IWebElement bookingList => driver.FindElement(By.XPath("//div/ul/li[3]/div[@class=\"ant-menu-submenu-title\"]"));
        IWebElement bookingManagerOption => driver.FindElement(By.XPath("//*[@href=\"/booking/manager/:tab\"]"));
        IWebElement goToTheBookingManagerButton => driver.FindElement(By.XPath("//*[@class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]"));
        IWebElement pendingTermList => driver.FindElement(By.XPath("//div[2]/div[2]/div/span/div/div/div[@class=\"ant-select-selection__rendered\"]"));
        IWebElement termOneTF => driver.FindElement(By.XPath("//div/div/ul/li[1][contains(text(),\"Term 2 2024\")]"));
        IWebElement filterByAccountName => driver.FindElement(By.XPath("//div[2]/div/div/ul/li/div/input[@class=\"ant-input ant-select-search__field\"]"));
        IWebElement firstAccount => driver.FindElement(By.XPath("//div/div[3]/span[2][@class=\"ant-typography ant-typography-secondary\"]"));
        IWebElement applyButton => driver.FindElement(By.XPath("//div[5]/div/div/span/button[2][@class=\"ant-btn ant-btn-primary\"]"));

        public void goToTheBookingManagerPage()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]");
            goToTheBookingManagerButton.Click();
        }

        public void goToTheBookingManagerPageByUsingList()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div/ul/li[3]/div[@class=\"ant-menu-submenu-title\"]");
            bookingList.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@href=\"/booking/manager/:tab\"]");
            bookingManagerOption.Click();
        }

        public void ValidateAttendees(string accountName)
        {
            Wait.WaitToBeVisible("XPath", 5, "//div[2]/div/div/ul/li/div/input[@class=\"ant-input ant-select-search__field\"]");
            filterByAccountName.SendKeys(accountName);

            Wait.WaitToBeClickable("XPath", 5, "//div/div[3]/span[2][@class=\"ant-typography ant-typography-secondary\"]");
            firstAccount.Click();

            //Wait.WaitToBeClickable("XPath", 5, "//div[5]/div/div/span/button[2][@class=\"ant-btn ant-btn-primary\"]");
            //applyButton.Click();
        }
    }
}