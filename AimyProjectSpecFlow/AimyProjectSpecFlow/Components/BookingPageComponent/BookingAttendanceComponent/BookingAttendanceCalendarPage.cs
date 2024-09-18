using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Components.BookingPageComponent.BookingAttendanceComponent
{
    public class BookingAttendanceCalendarPage: Hook
    {
        IWebElement bookingList => driver.FindElement(By.XPath("//li[3]/div/span/span[contains(text(), \"Booking\")]"));
        IWebElement attendanceManagerOption => driver.FindElement(By.XPath("//*[@href=\"/booking/attendance/calendar\"]"));

    }
}
