using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace TestAutomationProject.Components.CustomersPageComponent
{
    public class AddNewEmergencyContact: Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//*[contains(text(), 'Customers')]"));
        private IWebElement accountsOption => driver.FindElement(By.XPath("//a[@href=\"/customer/account\"]"));
        private IWebElement accountSearchBar => driver.FindElement(By.XPath("//*[@placeholder=\"Search here\"]"));
        private IWebElement selectAccount => driver.FindElement(By.XPath("//*[contains(text(), \"Andy\")]"));
        private IWebElement selectEmergencyContact => driver.FindElement(By.XPath("//div[contains(text(), \"Emergency Contact\")]"));
        private IWebElement newEmergencyContactButton => driver.FindElement(By.XPath("//div/div[2]/div/div[1]/div/button[@type=\"button\"]"));
        private IWebElement ecFirstName => driver.FindElement(By.Id("firstName"));
        private IWebElement ecMiddleName => driver.FindElement(By.Id("middleName"));
        private IWebElement ecLastName => driver.FindElement(By.Id("lastName"));
        private IWebElement ecHomePhoneArea => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement ecHomePhoneNum => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement ecWorkPhoneArea => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement ecWorkPhoneNum => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement ecWorkPhoneExt => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]"));
        private IWebElement ecAddressButton => driver.FindElement(By.XPath("//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement ecLocation => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement ecStreetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement ecSuburb => driver.FindElement(By.Id("suburb"));
        private IWebElement ecCity => driver.FindElement(By.Id("city"));
        private IWebElement ecRegion => driver.FindElement(By.Id("region"));
        private IWebElement ecCountry => driver.FindElement(By.Id("country"));
        private IWebElement ecPostalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement ecSaveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveTheContactButton => driver.FindElement(By.XPath("//div[2]/div/button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement ecSuccessMessage => driver.FindElement(By.XPath("//*[contains(text(), \"Data saved successfully\")]"));

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

           
            // Fluent wait for  the "selectAccount" element
            Wait.WaitToBeClickable("XPath", 10, "//*[contains(text(), \"Andy\")]");
            selectAccount.Click();
        }
        public void ClickEmergencyContactButton()
        {
            // Fluent wait for the "selectEmergencyContact" element
            Wait.WaitToBeClickable("XPath", 5, "//div[contains(text(), \"Emergency Contact\")]");
            selectEmergencyContact.Click();
        }

        public void CreateEmergencyContact(string emergencyContactFirstName, string emrgencyContactMiddleName, string emergencyContactLastName, string emergencyContactHomePhoneArea, string emergencyContactHomePhoneNum, string emergencyContactWorkPhoneArea, string emergencyContactWorkPhoneNum, string emergencyContactWorkPhoneExt, string emergencyContactLocation, string emergencyContactStreetAddress, string emergencyContactSuburb, string emergencyContactCity, string emergencyContactRegion, string emergencyContactCountry, string emergencyContactPostalCode)
        {
            // Fluent wait for the "newEmergencyContactButton" element
            Wait.WaitToBeClickable("XPath", 10, "//div/div[2]/div/div[1]/div/button[@type=\"button\"]");
            newEmergencyContactButton.Click();

            // Fluent wait for the "ecFirstName" element
            Wait.WaitToBeVisible("Id", 5, "firstName");
            ecFirstName.SendKeys(emergencyContactFirstName);
            ecMiddleName.SendKeys(emrgencyContactMiddleName);
            ecLastName.SendKeys(emergencyContactLastName);
            //ecEmail.SendKeys(emergencyContactEmail);

            //Wait.WaitToBeVisible("XPath", 5, "//label[2]/span[contains(text(), 'Male')]");
            //ecGenderMale.Click();

            //ecMobile.SendKeys(emergencyContactMobile);

            Wait.WaitToBeVisible("XPath", 5, "//div[7]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            ecHomePhoneArea.SendKeys(emergencyContactHomePhoneArea);
            ecHomePhoneNum.SendKeys(emergencyContactHomePhoneNum);

            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            ecWorkPhoneArea.SendKeys(emergencyContactWorkPhoneArea);
            ecWorkPhoneNum.SendKeys(emergencyContactWorkPhoneNum);

            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]");
            ecWorkPhoneExt.SendKeys(emergencyContactWorkPhoneExt);

            Wait.WaitToBeClickable("XPath", 5, "//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            ecAddressButton.Click();

            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Enter a location']");
            ecLocation.SendKeys(emergencyContactLocation);
            ecStreetAddress.SendKeys(emergencyContactStreetAddress);
            ecSuburb.SendKeys(emergencyContactSuburb);
            ecCity.SendKeys(emergencyContactCity);
            ecRegion.SendKeys(emergencyContactRegion);
            ecCountry.SendKeys(emergencyContactCountry);
            ecPostalCode.SendKeys(emergencyContactPostalCode);

            ecSaveButton.Click();

            saveTheContactButton.Click();
        }

        public string AssertMessage()
        {
            // Fluent wait for the "ecSuccessMessage" element
            Wait.WaitToBeVisible("XPath", 5, "//*[contains(text(), \"Data saved successfully\")]");
            return ecSuccessMessage.Text;
        }
    }
}