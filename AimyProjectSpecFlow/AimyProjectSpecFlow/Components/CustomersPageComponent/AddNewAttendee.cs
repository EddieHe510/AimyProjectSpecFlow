using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Components.CustomersPageComponent
{
    public class AddNewAttendee : Hook
    {
        private IWebElement customersList => driver.FindElement(By.XPath("//*[contains(text(), 'Customers')]"));
        private IWebElement attendeeOption => driver.FindElement(By.XPath("//*[@href=\"/customer/attendee\"]"));
        private IWebElement newAttendeeButton => driver.FindElement(By.XPath("//*[@class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]"));
        private IWebElement accountName => driver.FindElement(By.XPath("//*[@class=\"ant-input ant-select-search__field\"]"));
        // Name
        private IWebElement firstName => driver.FindElement(By.XPath("//div[2]/div[2]/div/span/input[@id=\"firstName\"]"));
        private IWebElement middleName => driver.FindElement(By.XPath("//div[3]/div[2]/div/span/input[@id=\"middleName\"]"));
        private IWebElement lastName => driver.FindElement(By.XPath("//div[4]/div[2]/div/span/input[@id=\"lastName\"]"));
        private IWebElement knownAs => driver.FindElement(By.XPath("//div[5]/div[2]/div/span/input[@id=\"knownName\"]"));
        // Ethnicity
        private IWebElement ethnicity => driver.FindElement(By.XPath("//div[2]/div[1]/div/form/div[6]/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]"));
        private IWebElement nzOption => driver.FindElement(By.XPath("//li[contains(text(), \"NZ European/ Pakeha\")]"));
        // Primary Language
        private IWebElement primaryLanguage => driver.FindElement(By.XPath("//div[7]/div[2]/div/span/div/div/div/div[1][contains(text(), \"Primary Language\")]"));
        private IWebElement afrikaansOption => driver.FindElement(By.XPath("//*[contains(text(), \"Afrikaans\")]"));
        
        // Swimming comertency
        private IWebElement swimmingCompetency => driver.FindElement(By.XPath("//div[8]/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]"));
        private IWebElement learnerOption => driver.FindElement(By.XPath("//li[2]/span[contains(text(), \"Learner\")]"));
        // Date of birth
        private IWebElement dateOfBirth => driver.FindElement(By.XPath("//div[9]/div[2]/div/span/span/div/input[@placeholder=\"dd/mmm/yyyy\"and@class=\"ant-calendar-picker-input ant-input\"]"));
        private IWebElement dateOfBirthYearSelect => driver.FindElement(By.XPath("//*[@class=\"ant-calendar-year-select\"]"));
        private IWebElement lastDecadeArrow => driver.FindElement(By.XPath("//*[@title=\"Last decade\"]"));
        private IWebElement oneEightOption => driver.FindElement(By.XPath("//*[contains(text(), \"2018\")]"));
        private IWebElement dateOfBirthMonthSelect => driver.FindElement(By.XPath("//*[@class=\"ant-calendar-month-select\"]"));
        private IWebElement MayOption => driver.FindElement(By.XPath("//*[contains(text(), \"May\")]"));
        private IWebElement tenOption => driver.FindElement(By.XPath("//div[2]/div[2]/table/tbody/tr[2]/td[4]/div[contains(text(), \"10\")]"));
        // Gender
        private IWebElement genderMaleOption => driver.FindElement(By.XPath("//div[10]/div[2]/div/span/div/label[2]/span[2][contains(text(), 'Male')]"));
        // School Year
        private IWebElement schoolYear => driver.FindElement(By.XPath("//div[11]/div[2]/div/span/div/div[2]/input[@class=\"ant-input-number-input\"]"));
        // Subsidy Nu,ber 
        private IWebElement subsidyNumber => driver.FindElement(By.XPath("//div[12]/div[2]/div/span/input[@id=\"socialBenefitNumber\"]"));
        // Address
        private IWebElement addressButton => driver.FindElement(By.XPath("//div[13]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]"));
        private IWebElement location => driver.FindElement(By.XPath("//input[@placeholder='Enter a location']"));
        private IWebElement streetAddress => driver.FindElement(By.Id("streetAddress"));
        private IWebElement suburb => driver.FindElement(By.Id("suburb"));
        private IWebElement city => driver.FindElement(By.Id("city"));
        private IWebElement region => driver.FindElement(By.Id("region"));
        private IWebElement country => driver.FindElement(By.Id("country"));
        private IWebElement postalCode => driver.FindElement(By.Id("postcode"));
        private IWebElement adressSaveButton => driver.FindElement(By.XPath("//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        // Note
        private IWebElement note => driver.FindElement(By.XPath("//div[14]/div[2]/div/span/textarea[@id=\"note\"]"));
        // Test Photo Consent
        private IWebElement yesOption => driver.FindElement(By.XPath("//div[14]/div[2]/div/span/div[1]/label[1]/span[2]/span[contains(text(), 'Yes')]"));
        // First relationship
        //private IWebElement firstRelationship => driver.FindElement(By.XPath("//div[2]/div[1]/div/div/div[2]/form[1]/div/div[2]/div/div/div/span/div/div/div/div[@unselectable=\"on\"and@class=\"ant-select-selection__placeholder\"]"));
        //private IWebElement firstRelationshipParentOption => driver.FindElement(By.XPath("//li[1][contains(text(), \"Parent\")]"));
        private IWebElement infoSaveButton => driver.FindElement(By.XPath("//div[2]/div[2]/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]"));
        private IWebElement saveSuccessMessage => driver.FindElement(By.XPath("//*[contains(text(), \"New Attendee Created\")]"));
        public void SelectAttendeeOption()
        {
            // Fluent wait for the "customersList" element
            Wait.WaitToBeClickable("XPath", 10, "//*[contains(text(), 'Customers')]");
            customersList.Click();

            // Fluent wait for the "attendeeOption" element
            Wait.WaitToBeClickable("XPath", 10, "//*[@href=\"/customer/attendee\"]");
            attendeeOption.Click();
        }


        public void CreateNewAttendee(string attendeeAccountName, string attendeeFirstName, string attendeeMiddleName, string attendeeLastName, string attendeeKnownAs, string attendeeSchoolYear, string attendeeSubsidyNumber, string attendeeLocation, string attendeeStreetAddress, string attendeeSuburb, string attendeeCity, string attendeeRegion, string attendeeCountry, string attendeePostalCode, string attendeeNote)
        {
            // Fluent wait for the "newAttendeeButton" element
            Wait.WaitToBeClickable("XPath", 10, "//*[@class=\"ant-btn ant-btn-primary ant-btn-background-ghost\"]");
            newAttendeeButton.Click();

            // Fluent wait for the "accountName" element
            Wait.WaitToBeVisible("XPath", 10, "//*[@class=\"ant-input ant-select-search__field\"]");
            accountName.SendKeys(attendeeAccountName);
            Thread.Sleep(1000);
            accountName.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            accountName.SendKeys(Keys.Enter);


            firstName.SendKeys(attendeeFirstName);
            middleName.SendKeys(attendeeMiddleName);
            lastName.SendKeys(attendeeLastName);
            knownAs.SendKeys(attendeeKnownAs);

            // Fluent wait for the "ethnicity" element
            Wait.WaitToBeClickable("XPath", 10, "//div[2]/div[1]/div/form/div[6]/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            ethnicity.Click();
            // Fluent wait for the "ethnicity" element
            Wait.WaitToBeClickable("XPath", 5, "//li[contains(text(), \"NZ European/ Pakeha\")]");
            nzOption.Click();

            Wait.WaitToBeVisible("XPath", 5, "//div[14]/div[2]/div/span/textarea[@id=\"note\"]");
            note.SendKeys(attendeeNote);

            // Fluent wait for the "primaryLanguage" element
            Wait.WaitToBeClickable("XPath", 5, "//div[7]/div[2]/div/span/div/div/div/div[1][contains(text(), \"Primary Language\")]");
            primaryLanguage.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Afrikaans\")]");
            afrikaansOption.Click();

            // Fluent wait for the "swimmingCompetency" element
            Wait.WaitToBeClickable("XPath", 5, "//div[8]/div[2]/div/span/div/div/div/div[@class=\"ant-select-selection__placeholder\"]");
            swimmingCompetency.Click();
            // Fluent wait for the "learnerOption" element
            Wait.WaitToBeClickable("XPath", 5, "//li[2]/span[contains(text(), \"Learner\")]");
            learnerOption.Click();

            Wait.WaitToBeClickable("XPath", 10, "//div[9]/div[2]/div/span/span/div/input[@placeholder=\"dd/mmm/yyyy\"and@class=\"ant-calendar-picker-input ant-input\"]");
            dateOfBirth.Click();
            dateOfBirthYearSelect.Click();
            lastDecadeArrow.Click();
            oneEightOption.Click();
            dateOfBirthMonthSelect.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"May\")]");
            MayOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/table/tbody/tr[2]/td[4]/div[contains(text(), \"10\")]");
            tenOption.Click();

            // Fluent wait for the "learnerOption" element
            Wait.WaitToBeClickable("XPath", 10, "//div[10]/div[2]/div/span/div/label[2]/span[2][contains(text(), 'Male')]");
            genderMaleOption.Click();

            Wait.WaitToBeVisible("XPath", 10, "//div[11]/div[2]/div/span/div/div[2]/input[@class=\"ant-input-number-input\"]");
            schoolYear.SendKeys(attendeeSchoolYear);

            Wait.WaitToBeVisible("XPath", 5, "//div[12]/div[2]/div/span/input[@id=\"socialBenefitNumber\"]");
            subsidyNumber.SendKeys(attendeeSubsidyNumber);

            // Fluent wait for the "addressButton" element
            Wait.WaitToBeVisible("XPath", 5, "//div[13]/div[2]/div/span/div/button[1][@type=\"button\"and@class=\"ant-btn\"]");
            addressButton.Click();
            location.SendKeys(attendeeLocation);
            streetAddress.SendKeys(attendeeStreetAddress);
            suburb.SendKeys(attendeeSuburb);
            city.SendKeys(attendeeCity);
            region.SendKeys(attendeeRegion);
            country.SendKeys(attendeeCountry);
            postalCode.SendKeys(attendeePostalCode);

            // Fluent wait for the "adressSaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            adressSaveButton.Click();

            //Fluent wait for the "Yes Option" for Test Photo Consent
            Wait.WaitToBeClickable("XPath", 5, "//div[14]/div[2]/div/span/div[1]/label[1]/span[2]/span[contains(text(), 'Yes')]");
            yesOption.Click();

            //// Fluent wait for the "firstRelationship" element
            //Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[1]/div/div/div[2]/form[1]/div/div[2]/div/div/div/span/div/div/div/div[@unselectable=\"on\"and@class=\"ant-select-selection__placeholder\"]");
            //firstRelationship.Click();
            //// Fluent wait for the "firstRelationshipParentOption" element
            //Wait.WaitToBeClickable("XPath", 5, "//li[1][contains(text(), \"Parent\")]");
            //firstRelationshipParentOption.Click();

            // Fluent wait for the "infoSaveButton" element
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/button[2][@type=\"button\"and@class=\"ant-btn ant-btn-primary\"]");
            infoSaveButton.Click();
        }

        public string assertAttendeeMessage()
        {
            // Fluent wait for the "saveSuccessMessage" element
            Wait.WaitToBeVisible("XPath", 5, "//*[contains(text(), \"New Attendee Created\")]");
            return saveSuccessMessage.Text;
        }
    }
}