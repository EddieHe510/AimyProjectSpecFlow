using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace TestAutomationProject.Components.CustomersPageComponent
{
    public class AddNewAccount : Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//div/ul/li[2]/div[1][@class=\"ant-menu-submenu-title\"]"));
        private IWebElement accountsOption => driver.FindElement(By.XPath("//a[@href=\"/customer/account\"]"));
        private IWebElement newAccountButton => driver.FindElement(By.XPath("//*[@type=\"button\"and @class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]"));
        private IWebElement sitesList => driver.FindElement(By.XPath("//div[contains(text(), 'Select Sites')]"));
        private IWebElement woodValleyPrimaryOption => driver.FindElement(By.XPath("//li[contains(text(), 'Wood Valley Primary')]"));
        private IWebElement nameTextBox => driver.FindElement(By.XPath("//div[2]/div[2]/div/span/input[@id='name']"));
        private IWebElement accountNumberTextBox => driver.FindElement(By.XPath("//div[3]/div[2]/div/span/input[@placeholder='Account Number']"));
        private IWebElement rateFourStar => driver.FindElement(By.XPath("//div[4]/div[2]/div/span/ul/li[4]/div[@role=\"radio\"and@aria-posinset=\"4\"]"));
        private IWebElement pcFirstname => driver.FindElement(By.Id("firstName"));
        private IWebElement pcMiddlename => driver.FindElement(By.Id("middleName"));
        private IWebElement pcLastname => driver.FindElement(By.Id("lastName"));
        private IWebElement pcEmail => driver.FindElement(By.Id("email"));
        private IWebElement pcMobile => driver.FindElement(By.XPath("//*[@placeholder=\"Mobile Num\"]"));
        private IWebElement pcHomePhoneAreaCode => driver.FindElement(By.XPath("//div[14]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement pcHomePhoneLocalNum => driver.FindElement(By.XPath("//div[14]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement pcWorkPhoneAreaCode => driver.FindElement(By.XPath("//div[15]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement pcWorkPhoneLocalNum => driver.FindElement(By.XPath("//div[15]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement pcWorkPhoneExt => driver.FindElement(By.XPath("//input[@placeholder='Ext']"));
        private IWebElement pcPhysicalAddressButton => driver.FindElement(By.XPath("//div[16]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement pALocation => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement pAStreetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement pASuburb => driver.FindElement(By.Id("suburb"));
        private IWebElement pACity => driver.FindElement(By.Id("city"));
        private IWebElement pARegion => driver.FindElement(By.Id("region"));
        private IWebElement pACountry => driver.FindElement(By.Id("country"));
        private IWebElement pAPostalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement pASaveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement pcBillingAddressButton => driver.FindElement(By.XPath("//div[18]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement bALocation => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement bAStreetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement bASuburb => driver.FindElement(By.Id("suburb"));
        private IWebElement bACity => driver.FindElement(By.Id("city"));
        private IWebElement bARegion => driver.FindElement(By.Id("region"));
        private IWebElement bACountry => driver.FindElement(By.Id("country"));
        private IWebElement bAPostalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement bASaveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveNewAccountInfoButton => driver.FindElement(By.XPath("//div[2]/div[2]/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveSuccessMessage => driver.FindElement(By.XPath("//*[contains(text(), \"New Account Created\")]"));

        public void SelectAccountsOption()
        {
            // Fluent wait for the "customersList" element
            Wait.WaitToBeClickable("XPath", 10, "//div/ul/li[2]/div[1][@class=\"ant-menu-submenu-title\"]");
            customersList.Click();

            // Fluent wait for the "accountsOption" element
            Wait.WaitToBeClickable("XPath", 10, "//a[@href=\"/customer/account\"]");
            accountsOption.Click();
        }


        public void CreateNewAccount(string name, string accountNumber, string firstName, string middleName, string lastName, string email, string mobile, string homePhoneAreaCode, string homePhoneLocalNum, string workPhoneAreaCode, string workPhoneLocalNum, string workPhoneExt, string paLocation, string paStreetAddress, string paSuburb, string paCity, string paRegion, string paCountry, string paPostalCode, string subsidynumber, string baLocation, string baStreetAddress, string baSuburb, string baCity, string baRegion, string baCountry, string baPostalCode)
        {
            // Fluent wait for the "newAccountButton" element
            Wait.WaitToBeClickable("XPath", 15, "//*[@type=\"button\"and @class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]");
            newAccountButton.Click();

            // Fluent wait for the "sitesList" element
            Wait.WaitToBeClickable("XPath", 5, "//div[contains(text(), 'Select Sites')]");
            sitesList.Click();

            // Fluent wait for the "aucklandOption" element
            Wait.WaitToBeClickable("XPath", 5, "//li[contains(text(), 'Wood Valley Primary')]");
            woodValleyPrimaryOption.Click();

            nameTextBox.SendKeys(name);

            // Fluent wait for the "accountNumberTextBox" element
            Wait.WaitToBeVisible("XPath", 5, "//div[3]/div[2]/div/span/input[@placeholder='Account Number']");
            accountNumberTextBox.SendKeys(accountNumber);

            // Fluent wait for the "rateFourStar" element
            Wait.WaitToBeVisible("XPath", 5, "//div[4]/div[2]/div/span/ul/li[4]/div[@role=\"radio\"and@aria-posinset=\"4\"]");
            rateFourStar.Click();

            pcFirstname.SendKeys(firstName);
            pcMiddlename.SendKeys(middleName);
            pcLastname.SendKeys(lastName);
            pcEmail.SendKeys(email);

            pcMobile.SendKeys(mobile);

            // Fluent wait for the "pcHomePhoneAreaCode" element
            Wait.WaitToBeVisible("XPath", 5, "//div[14]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            pcHomePhoneAreaCode.SendKeys(homePhoneAreaCode);
            pcHomePhoneLocalNum.SendKeys(homePhoneLocalNum);

            // Fluent wait for the "pcWorkPhoneAreaCode" element
            Wait.WaitToBeVisible("XPath", 5, "//div[15]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            pcWorkPhoneAreaCode.SendKeys(workPhoneAreaCode);
            pcWorkPhoneLocalNum.SendKeys(workPhoneLocalNum);

            // Fluent wait for the "pcWorkPhoneExt" element
            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Ext']");
            pcWorkPhoneExt.SendKeys(workPhoneExt);

            // Fluent wait for the "pcPhysicalAddressButton" element
            Wait.WaitToBeVisible("XPath", 5, "//div[16]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            pcPhysicalAddressButton.Click();

            // Fluent wait for the "pALocation" element
            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Enter a location']");
            pALocation.SendKeys(paLocation);
            pAStreetAddress.SendKeys(paStreetAddress);
            pASuburb.SendKeys(paSuburb);
            pACity.SendKeys(paCity);
            pARegion.SendKeys(paRegion);
            pACountry.SendKeys(paCountry);
            pAPostalCode.SendKeys(paPostalCode);

            // Fluent wait for the "pASaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            pASaveButton.Click();

            // Fluent wait for the "pcBillingAddressButton" element
            Wait.WaitToBeVisible("XPath", 5, "//div[18]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            pcBillingAddressButton.Click();

            // Fluent wait for the "bALocation" element
            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Enter a location']");
            bALocation.SendKeys(baLocation);
            bAStreetAddress.SendKeys(baStreetAddress);
            bASuburb.SendKeys(baSuburb);
            bACity.SendKeys(baCity);
            bARegion.SendKeys(baRegion);
            bACountry.SendKeys(baCountry);
            bAPostalCode.SendKeys(baPostalCode);

            // Fluent wait for the "bASaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            bASaveButton.Click();

            // Fluent wait for the "saveNewAccountInfoButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            saveNewAccountInfoButton.Click();
        }

        public string assertAccount()
        {
            // Fluent wait for the "saveSuccessMessage" element
            Wait.WaitToBeVisible("XPath", 5, "//*[contains(text(), \"New Account Created\")]");
            return saveSuccessMessage.Text;
        }
    }
}