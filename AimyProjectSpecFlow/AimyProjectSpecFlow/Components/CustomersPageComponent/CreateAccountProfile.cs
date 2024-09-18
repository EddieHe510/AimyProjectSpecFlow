using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace TestAutomationProject.Components.CustomersPageComponent
{
    public class CreateAccountProfile : Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//*[contains(text(), 'Customers')]"));
        private IWebElement accountsOption => driver.FindElement(By.XPath("//a[@href=\"/customer/account\"]"));
        private IWebElement accountSearchBar => driver.FindElement(By.XPath("//*[@placeholder=\"Search here\"]"));
        private IWebElement selectAccount => driver.FindElement(By.XPath("//li[2]/div/div[@class=\"ant-list-item-meta-content\"]"));
        private IWebElement profileButton => driver.FindElement(By.XPath("//div[1][@class=\" ant-tabs-tab\"]"));
        private IWebElement profileName => driver.FindElement(By.XPath("//*[@placeholder=\"Name\"]"));
        private IWebElement profileAccountNumber => driver.FindElement(By.XPath("//*[@placeholder=\"Account Number\"]"));
        private IWebElement profileSelectFourStar => driver.FindElement(By.XPath("//div[@role=\"radio\"and@aria-posinset=\"4\"]"));
        private IWebElement profileStatus => driver.FindElement(By.XPath("//span/div/div/div[@class=\"ant-select-selection__rendered\"]"));
        private IWebElement profileStatusArchivedOption => driver.FindElement(By.XPath("//li[contains(text(), \"Archived\")]"));
        private IWebElement profileSaveButton => driver.FindElement(By.XPath("//button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveProfileMessage => driver.FindElement(By.XPath("//*[contains(text(), \"Data saved successfully\")]"));

        public void profilePageButton()
        {
            profileButton.Click();
        }


        public void searchAccountProfile(string accountName)
        {
            customersList.Click();

            // Fluent wait for the "accountOption" element
            Wait.WaitToBeClickable("XPath", 5, "//a[@href=\"/customer/account\"]");
            accountsOption.Click();

            // Fluent wait for the "accountSearchBar" element
            Wait.WaitToBeVisible("XPath", 10, "//*[@placeholder=\"Search here\"]");
            accountSearchBar.SendKeys(accountName);

            // Using Thread sleep to make the system accept Enter move
            Thread.Sleep(1000);
            accountSearchBar.SendKeys(Keys.Enter);

            // Fluent wait for the "selectAccount" element
            Wait.WaitToBeClickable("XPath", 10, "//li[2]/div/div[@class=\"ant-list-item-meta-content\"]");
            selectAccount.Click();
        }

        public void createAccountProfile(string newProfileName, string newProfileAccountNum)
        {
            // Fluent wait for the "profileName" element
            Wait.WaitToBeVisible("XPath", 5, "//*[@placeholder=\"Name\"]");
            profileName.SendKeys(newProfileName);

            // Fluent wait for the "profileAccountNumber" element
            Wait.WaitToBeVisible("XPath", 5, "//*[@placeholder=\"Account Number\"]");
            profileAccountNumber.SendKeys(newProfileAccountNum);

            // Fluent wait for the "profileSelectFourStar" element
            Wait.WaitToBeVisible("XPath", 5, "//div[@role=\"radio\"and@aria-posinset=\"4\"]");
            profileSelectFourStar.Click();

            // Select Archived Option
            // Fluent wait for the "profileStatus" element
            Wait.WaitToBeClickable("XPath", 5, "//span/div/div/div[@class=\"ant-select-selection__rendered\"]");
            profileStatus.Click();

            // Fluent wait for the "profileStatusArchivedOption" element
            Wait.WaitToBeClickable("XPath", 5, "//li[contains(text(), \"Archived\")]");
            profileStatusArchivedOption.Click();

            // Fluent wait for the "profileSaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            profileSaveButton.Click();
        }

        public string assertMessage()
        {
            // Fluent wait for the "saveProfileMessage" element
            Wait.WaitToBeVisible("XPath", 5, "//*[contains(text(), \"Data saved successfully\")]");
            return saveProfileMessage.Text;
        }
    }
}