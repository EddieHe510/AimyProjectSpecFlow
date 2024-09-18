using AimyOneLoginTest.Components.LoginPageComponent;
using AimyOneLoginTest.TestData.LoginCredential;
using Newtonsoft.Json;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationProject.Components.BookingPageComponent;
using TestAutomationProject.Components.LoginPageComponent;

namespace TestAutomationProject.FeatureStepDefinitions
{
    [Binding]
    [TestFixture]
    public class BookingStepDefinitions
    {
        private Login login;
        private SwitchBusinessUnit switchUnit;
        private BookingPage bookingPage;
        private BookingManagerPage bookingManagerPage;


        public BookingStepDefinitions()
        {
            login = new Login();
            switchUnit = new SwitchBusinessUnit();
            bookingPage = new BookingPage();
            bookingManagerPage = new BookingManagerPage();
        }

        [Then(@"I would like to switch my account to Demo unit")]
        public void ThenIWouldLikeToSwitchMyAccountToDemoUnit()
        {
            switchUnit.selectAimyDemoUnit();
        }


        [Then(@"I start using booking system to book an class for my attendee")]
        public void ThenIStartUsingBookingSystemToBookAnClassForMyAttendee()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string accountName = jsonData.accountName;

            bookingPage.bookingForFirstAttendee(accountName);
        }

        [When(@"I click the go to Booking Mangaer button after submited an class")]
        public void WhenIClickTheGoToBookingMangaerButtonAfterSubmitedAnClass()
        {
            bookingManagerPage.goToTheBookingManagerPage();
        }


        [Then(@"I go to booking manager page to validate my attendee program")]
        public void ThenIGoToBookingManagerPageToValidateMyAttendeeProgram()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string accountName = jsonData.accountName;

            bookingManagerPage.ValidateAttendees(accountName);
        }

        [Then(@"I back to booking page and book an same class for my second attendee")]
        public void ThenIBackToBookingPageAndBookAnSameClassForMySecondAttendee()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string accountName = jsonData.accountName;

            bookingPage.bookingForSecondAttendee(accountName);
        }

        [Then(@"I click the go to booking manager button and I should see two attendee in same class")]
        public void ThenIClickTheGoToBookingManagerButtonAndIShouldSeeTwoAttendeeInSameClass()
        {
            bookingManagerPage.goToTheBookingManagerPage();
        }
    }
}
