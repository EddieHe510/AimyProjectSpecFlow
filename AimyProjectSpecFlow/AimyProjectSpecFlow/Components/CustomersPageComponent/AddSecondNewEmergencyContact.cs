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
    public class AddSecondNewEmergencyContact : Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//*[contains(text(), 'Customers')]"));
        private IWebElement accountsOption => driver.FindElement(By.XPath("//a[@href=\"/customer/account\"]"));
        private IWebElement accountSearchBar => driver.FindElement(By.XPath("//*[@placeholder=\"Search here\"]"));
        private IWebElement selectAccount => driver.FindElement(By.XPath("//*[contains(text(), \"Wendy\")]"));
        private IWebElement selectEmergencyContact => driver.FindElement(By.XPath("//div[contains(text(), \"Emergency Contact\")]"));
        private IWebElement newEmergencyContactButton => driver.FindElement(By.XPath("//div/div[2]/div/div[1]/div/button[@type=\"button\"]"));
        private IWebElement firstName => driver.FindElement(By.Id("firstName"));
        private IWebElement middleName => driver.FindElement(By.Id("middleName"));
        private IWebElement lastName => driver.FindElement(By.Id("lastName"));
        private IWebElement homePhoneArea => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement homePhoneNum => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement workPhoneArea => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]"));
        private IWebElement workPhoneNum => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[2][@placeholder=\"Local Num\"]"));
        private IWebElement workPhoneExt => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]"));
        private IWebElement addressButton => driver.FindElement(By.XPath("//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement location => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement streetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement suburb => driver.FindElement(By.Id("suburb"));
        private IWebElement city => driver.FindElement(By.Id("city"));
        private IWebElement region => driver.FindElement(By.Id("region"));
        private IWebElement country => driver.FindElement(By.Id("country"));
        private IWebElement postalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveTheContactButton => driver.FindElement(By.XPath("//div[2]/div/button[@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement subsidyNumber => driver.FindElement(By.XPath("//*[@id=\"socialBenefitNumber\"]"));
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
            Wait.WaitToBeClickable("XPath", 10, "//*[contains(text(), \"Wendy\")]");
            selectAccount.Click();
            
        }

        public void ClickEmergencyContactButton()
        {
            // Fluent wait for the "selectEmergencyContact" element
            Wait.WaitToBeClickable("XPath", 5, "//div[contains(text(), \"Emergency Contact\")]");
            selectEmergencyContact.Click();
        }

        public void CreateNewEmergencyContact(string emergencyContactFirstName, string emrgencyContactMiddleName, string emergencyContactLastName,  string emergencyContactHomePhoneArea, string emergencyContactHomePhoneNum, string emergencyContactWorkPhoneArea, string emergencyContactWorkPhoneNum, string emergencyContactWorkPhoneExt, string emergencyContactLocation, string emergencyContactStreetAddress, string emergencyContactSuburb, string emergencyContactCity, string emergencyContactRegion, string emergencyContactCountry, string emergencyContactPostalCode)
        {
            // Fluent wait for the "newEmergencyContactButton" element
            Wait.WaitToBeClickable("XPath", 10, "//div/div[2]/div/div[1]/div/button[@type=\"button\"]");
            newEmergencyContactButton.Click();

            // Fluent wait for the "ecFirstName" element
            Wait.WaitToBeVisible("Id", 5, "firstName");
            firstName.SendKeys(emergencyContactFirstName);
            middleName.SendKeys(emrgencyContactMiddleName);
            lastName.SendKeys(emergencyContactLastName);


            // Fluent wait for the "homePhoneArea" element
            Wait.WaitToBeVisible("XPath", 5, "//div[9]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            homePhoneArea.SendKeys(emergencyContactHomePhoneArea);
            homePhoneNum.SendKeys(emergencyContactHomePhoneNum);

            // Fluent wait for the "workPhoneArea" element
            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div[2]/div/span/span/input[1][@placeholder=\"Area Code\"]");
            workPhoneArea.SendKeys(emergencyContactWorkPhoneArea);
            workPhoneNum.SendKeys(emergencyContactWorkPhoneNum);

            // Fluent wait for the "workPhoneExt" element
            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div[2]/div/span/span/input[3][@placeholder=\"Ext\"]");
            workPhoneExt.SendKeys(emergencyContactWorkPhoneExt);

            // Fluent wait for the "addressButton" element
            Wait.WaitToBeClickable("XPath", 5, "//span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            addressButton.Click();

            Wait.WaitToBeVisible("XPath", 5, "//input[@placeholder='Enter a location']");
            location.SendKeys(emergencyContactLocation);
            streetAddress.SendKeys(emergencyContactStreetAddress);
            suburb.SendKeys(emergencyContactSuburb);
            city.SendKeys(emergencyContactCity);
            region.SendKeys(emergencyContactRegion);
            country.SendKeys(emergencyContactCountry);
            postalCode.SendKeys(emergencyContactPostalCode);

            saveButton.Click();

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