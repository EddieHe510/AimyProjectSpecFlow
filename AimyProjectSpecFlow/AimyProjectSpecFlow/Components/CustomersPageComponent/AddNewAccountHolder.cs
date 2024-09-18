using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace TestAutomationProject.Components.CustomersPageComponent
{
    public class AddNewAccountHolder: Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//*[contains(text(), 'Customers')]"));
        private IWebElement accountsOption => driver.FindElement(By.XPath("//a[@href=\"/customer/account\"]"));
        private IWebElement accountSearchBar => driver.FindElement(By.XPath("//*[@placeholder=\"Search here\"]"));
        private IWebElement selectAccount => driver.FindElement(By.XPath("//*[contains(text(), \"Andy\")]"));
        private IWebElement newAccountHolderButton => driver.FindElement(By.XPath("//div[1]/button[@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement ahFirstName => driver.FindElement(By.Id("firstName"));
        private IWebElement ahMiddleName => driver.FindElement(By.Id("middleName"));
        private IWebElement ahLastName => driver.FindElement(By.Id("lastName"));
        //private IWebElement ahEmail => driver.FindElement(By.Id("email"));
        private IWebElement ahGenderMale => driver.FindElement(By.XPath("//*[contains(text(), 'Male')]"));
        private IWebElement ahMobile => driver.FindElement(By.XPath("//*[@placeholder=\"Mobile Num\"]"));
        private IWebElement ahHomePhoneArea => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement ahHomePhoneNum => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement ahWorkPhoneArea => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement ahWorkPhoneNum => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement ahWorkPhoneExt => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]"));
        private IWebElement ahAddressButton => driver.FindElement(By.XPath("//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement ahLocation => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement ahStreetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement ahSuburb => driver.FindElement(By.Id("suburb"));
        private IWebElement ahCity => driver.FindElement(By.Id("city"));
        private IWebElement ahRegion => driver.FindElement(By.Id("region"));
        private IWebElement ahCountry => driver.FindElement(By.Id("country"));
        private IWebElement ahPostalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement ahSaveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveTheContactButton => driver.FindElement(By.XPath("//div[2]/div/button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement ahSuccessMessage => driver.FindElement(By.XPath("//*[contains(text(), \"Data saved successfully\")]"));


        public void searchAccountProfile(string searchBar)
        {
            customersList.Click();

            // Fluent wait for the "accountOption" element
            Wait.WaitToBeClickable("XPath", 5, "//a[@href=\"/customer/account\"]");
            accountsOption.Click();

            // Fluent wait for the "accountSearchBar" element
            Wait.WaitToBeVisible("XPath", 10, "//*[@placeholder=\"Search here\"]");
            accountSearchBar.SendKeys(searchBar);

            // Using Thread sleep to make the system accept Enter move
            Thread.Sleep(1000);
            accountSearchBar.SendKeys(Keys.Enter);

            // Fluent wait for the "selectAccount" element
            Wait.WaitToBeClickable("XPath", 10, "//*[contains(text(), \"Andy\")]");
            selectAccount.Click();
        }

        public void CreateAccountHolder(string accountHolderFirstName, string accountHolderMiddleName, string accountHolderLastName, string accountHolderHomePhoneArea, string accountHolderHomePhoneNum, string accountHolderWorkPhoneArea, string accountHolderWorkPhoneNum, string accountHolderWorkPhoneExt, string accountHolderLocation, string accountHolderStreetAddress, string accountHolderSuburb, string accountHolderCity, string accountHolderRegion, string accountHolderCountry, string accountHolderPostalCode)
        {
            // Fluent wait for the "newAccountHolderButton" element
            Wait.WaitToBeClickable("XPath", 10, "//div[1]/button[@type=\"button\"and@class=\"ant-btn\"]");
            newAccountHolderButton.Click();

            // Fluent wait for the "ahFirstName" element
            Wait.WaitToBeVisible("Id", 5, "firstName");
            ahFirstName.SendKeys(accountHolderFirstName);
            ahMiddleName.SendKeys(accountHolderMiddleName);
            ahLastName.SendKeys(accountHolderLastName);
            //ahEmail.SendKeys(accountHolderEmail);

            //// Fluent wait for the "ahGenderMale" element
            //Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), 'Male')]");
            //ahGenderMale.Click();
            //Wait.WaitToBeVisible("XPath", 5, "//*[@placeholder=\"Mobile Num\"]");
            //ahMobile.SendKeys(accountHolderMobile);

            // Fluent wait for the "ahHomePhoneArea" element
            Wait.WaitToBeVisible("XPath", 5, "//div[7]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            ahHomePhoneArea.SendKeys(accountHolderHomePhoneArea);
            Wait.WaitToBeVisible("XPath", 5, "//div[7]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]");
            ahHomePhoneNum.SendKeys(accountHolderHomePhoneNum);

            // Fluent wait for the "ahWorkPhoneArea" element
            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            ahWorkPhoneArea.SendKeys(accountHolderWorkPhoneArea);
            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]");
            ahWorkPhoneNum.SendKeys(accountHolderWorkPhoneNum);
            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]");
            ahWorkPhoneExt.SendKeys(accountHolderWorkPhoneExt);

            // Fluent wait for the "ahAddressButton" element
            Wait.WaitToBeVisible("XPath", 5, "//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            ahAddressButton.Click();

            // Fluent wait for the "ahLocation" element
            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Enter a location']");
            ahLocation.SendKeys(accountHolderLocation);
            ahStreetAddress.SendKeys(accountHolderStreetAddress);
            ahSuburb.SendKeys(accountHolderSuburb);
            ahCity.SendKeys(accountHolderCity);
            ahRegion.SendKeys(accountHolderRegion);
            ahCountry.SendKeys(accountHolderCountry);
            ahPostalCode.SendKeys(accountHolderPostalCode);

            // Fluent wait for the "ahSaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            ahSaveButton.Click();

            // Fluent wait for the "saveTheContactButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            saveTheContactButton.Click();
        }

        public string AssertMessage()
        {
            // Fluent wait for the "ahSuccessMessage" element
            Wait.WaitToBeVisible("XPath", 5, "//*[contains(text(), \"Data saved successfully\")]");
            return ahSuccessMessage.Text;
        }
    }
}