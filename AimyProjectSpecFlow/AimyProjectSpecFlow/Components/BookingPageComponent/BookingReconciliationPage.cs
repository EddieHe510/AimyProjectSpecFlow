using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Components.BookingPageComponent
{
    public class BookingReconciliationPage: Hook
    {
        IWebElement bookingList => driver.FindElement(By.XPath("//li[3]/div/span/span[contains(text(), \"Booking\")]"));
        IWebElement bookingReconciliationOption => driver.FindElement(By.XPath("//*[@href=\"/booking/reconciliation\"]"));

    }
}
