using AimyOneLoginTest.Components.LoginPageComponent;
using AimyOneLoginTest.TestData.LoginCredential;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationProject.Components.CustomersPageComponent;
using TestAutomationProject.Components.LoginPageComponent;

namespace TestAutomationProject.FeatureStepDefinitions
{
    [Binding]
    public class CreateNewAccountStepDefinitions
    {
        private Login login;
        private SwitchBusinessUnit switchUnit;
        private AddNewAccount addNewAccount;
        private AddNewAccountHolder addNewAccountHolder;
        private AddNewEmergencyContact addNewEmergencyContact;
        private AddSecondNewEmergencyContact addSecondNewEmergencyContact;
        private CreateAccountProfile createAccountProfile;
        private AddNewAttendee addNewAttendee;

        public CreateNewAccountStepDefinitions()
        {
            login = new Login();
            switchUnit = new SwitchBusinessUnit();
            addNewAccount = new AddNewAccount();
            addNewAccountHolder = new AddNewAccountHolder();
            addNewEmergencyContact = new AddNewEmergencyContact();
            createAccountProfile = new CreateAccountProfile();
            addSecondNewEmergencyContact = new AddSecondNewEmergencyContact();
            addNewAttendee = new AddNewAttendee();
        }
       

        [Given(@"I use existing user credentials to login to portal")]
        public void GivenIUseExistingUserCredentialsToLoginToPortal()
        {
            string jsonPath = @"..\..\..\TestData\NewAccountFiles\AccountDetails.json";
            string jsonContent = File.ReadAllText(jsonPath);
            int testRunCount = GetTestRunCount();
            
            List<UserData> userData = JsonConvert.DeserializeObject<List<UserData>>(jsonContent);
            UserData firstUserData = userData.FirstOrDefault();

            string originalName = firstUserData.accountName;
            string updatedName = GetUpdatedName(originalName, testRunCount);

            firstUserData.accountName = updatedName;

            // Update the JSON file
            UpdateJsonFile(jsonPath, userData);

            ScenarioContext.Current.Set(firstUserData, "UserData");
        }
        private int GetTestRunCount()
        {
            string testRunCountPath = @"..\..\..\TestData\NewAccountFiles\TestRunCount.txt";

            int testRunCount = 1;

            if (File.Exists(testRunCountPath))
            {
                string countString = File.ReadAllText(testRunCountPath);
                if (int.TryParse(countString, out int storedCount))
                {
                    testRunCount = storedCount + 1;
                }
            }

            File.WriteAllText(testRunCountPath, testRunCount.ToString());

            return testRunCount;
        }

        private string GetUpdatedName(string originalName, int testRunCount)
        {
            // Form the updated name
            string updatedName = $"{originalName} {testRunCount:D2}";

            return updatedName;
        }

        private void UpdateJsonFile(string jsonPath, List<UserData> userData)
        {
            // Serialize the updated user data list to JSON
            string updatedJsonContent = JsonConvert.SerializeObject(userData, Formatting.Indented);

            // Write the updated JSON content back to the file
            File.WriteAllText(jsonPath, updatedJsonContent);
        }

        [When(@"I enter my user name and password")]
        public void WhenIEnterMyUserNameAndPassword()
        {
           
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string loginUsername = jsonData.username;
            string loginPassword = jsonData.password;

            login.loginWithCredentails(loginUsername, loginPassword);
        }

        [Then(@"I should be able to see the protal page")]
        public void ThenIShouldBeAbleToSeeTheProtalPage()
        {
            string expecedAccountName = login.assertUsername();
            Assert.That(expecedAccountName == "hlhedison@gmail.com", "Actual account name and expected account name do not match!");
        }

        [Then(@"I would like to switch the account to Demo unit")]
        public void ThenIWouldLikeToSwitchTheAccountToDemoUnit()
        {
            switchUnit.selectAimyDemoUnit();
        }

        [Then(@"I select Customer list and select the Account option")]
        public void ThenISelectCustomerListAndSelectTheAccountOption()
        {
            addNewAccount.SelectAccountsOption();
        }

        [Then(@"I click the New Account button and start input the details")]
        public void ThenIClickTheNewAccountButtonAndStartInputTheDetails()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string Name = jsonData.accountName;
            string AccountNumber = jsonData.accountDetails.ElementAt(0).accountNumber;
            string PrimaryContactFirstName = jsonData.accountDetails.ElementAt(0).firstName;
            string PrimaryContactMiddleName = jsonData.accountDetails.ElementAt(0).middleName;
            string PrimaryContactLastName = jsonData.accountDetails.ElementAt(0).lastName;
            string Email = jsonData.accountDetails.ElementAt(0).email;
            string Mobile = jsonData.accountDetails.ElementAt(0).mobile;
            string HomePhoneAreaCode = jsonData.accountDetails.ElementAt(0).homePhoneAreaCode;
            string HomePhoneLocalNum = jsonData.accountDetails.ElementAt(0).homePhoneLocalNum;
            string WorkPhoneAreaCode = jsonData.accountDetails.ElementAt(0).workPhoneAreaCode;
            string WorkPhoneLocalNum = jsonData.accountDetails.ElementAt(0).workPhoneLocalNum;
            string WorkPhoneExt = jsonData.accountDetails.ElementAt(0).workPhoneExt;
            string PALocation = jsonData.accountDetails.ElementAt(0).paLocation;
            string PAStreetAddress = jsonData.accountDetails.ElementAt(0).paStreetAddress;
            string PASuburb = jsonData.accountDetails.ElementAt(0).paSuburb;
            string PACity = jsonData.accountDetails.ElementAt(0).paCity;
            string PARegion = jsonData.accountDetails.ElementAt(0).paRegion;
            string PACountry = jsonData.accountDetails.ElementAt(0).paCountry;
            string PAPostalCode = jsonData.accountDetails.ElementAt(0).paPostalCode;
            string SubsidyNumber = jsonData.accountDetails.ElementAt(0).subsidynumber;
            string BALocation = jsonData.accountDetails.ElementAt(0).baLocation;
            string BAStreetAddress = jsonData.accountDetails.ElementAt(0).baStreetAddress;
            string BASuburb = jsonData.accountDetails.ElementAt(0).baSuburb;
            string BACity = jsonData.accountDetails.ElementAt(0).baCity;
            string BARegion = jsonData.accountDetails.ElementAt(0).baRegion;
            string BACountry = jsonData.accountDetails.ElementAt(0).baCountry;
            string BAPostalCode = jsonData.accountDetails.ElementAt(0).baPostalCode;

            addNewAccount.CreateNewAccount(Name, AccountNumber, PrimaryContactFirstName, PrimaryContactMiddleName, PrimaryContactLastName, Email, Mobile, HomePhoneAreaCode, HomePhoneLocalNum, WorkPhoneAreaCode, WorkPhoneLocalNum, WorkPhoneExt, PALocation, PAStreetAddress, PASuburb, PACity, PARegion, PACountry, PAPostalCode, SubsidyNumber, BALocation, BAStreetAddress, BASuburb, BACity, BARegion, BACountry, BAPostalCode);
        }

        [Then(@"I should see the new account created message")]
        public void ThenIShouldSeeTheNewAccountCreatedMessage()
        {
            string expecedMessage = addNewAccount.assertAccount();
            Assert.That(expecedMessage == "New Account Created", "Actual message and expected message do not match!");
        }

        [Then(@"I add a new account holder to this account")]
        public void ThenIAddANewAccountHolderToThisAccount()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string ahFirstName = jsonData.accountHolder.ElementAt(0).firstName;
            string ahMiddleName = jsonData.accountHolder.ElementAt(0).middleName;
            string ahLastName = jsonData.accountHolder.ElementAt(0).lastName;
            string ahHomePhoneArea = jsonData.accountHolder.ElementAt(0).homePhoneArea;
            string ahHomePhoneNum = jsonData.accountHolder.ElementAt(0).homePhoneNum;
            string ahWorkPhoneArea = jsonData.accountHolder.ElementAt(0).workPhoneArea;
            string ahWorkPhoneNum = jsonData.accountHolder.ElementAt(0).workPhoneNum;
            string ahWorkPhoneExt = jsonData.accountHolder.ElementAt(0).workPhoneExt;
            string ahLocation = jsonData.accountHolder.ElementAt(0).location;
            string ahStreetAddress = jsonData.accountHolder.ElementAt(0).streetAddress;
            string ahSuburb = jsonData.accountHolder.ElementAt(0).suburb;
            string ahRegion = jsonData.accountHolder.ElementAt(0).region;
            string ahCity = jsonData.accountHolder.ElementAt(0).city;
            string ahCountry = jsonData.accountHolder.ElementAt(0).country;
            string ahPostalCode = jsonData.accountHolder.ElementAt(0).postalCode;

            addNewAccountHolder.CreateAccountHolder(ahFirstName, ahMiddleName, ahLastName, ahHomePhoneArea, ahHomePhoneNum, ahWorkPhoneArea, ahWorkPhoneNum, ahWorkPhoneExt, ahLocation, ahStreetAddress, ahSuburb, ahCity, ahRegion, ahCountry, ahPostalCode);
        }

        [Then(@"I should be able to see the save new account holder message")]
        public void ThenIShouldBeAbleToSeeTheSaveNewAccountHolderMessage()
        {
            string expecedMessage = addNewAccountHolder.AssertMessage();
            Assert.That(expecedMessage == "Data saved successfully", "Actual message and expected message do not match!");
        }

        [Then(@"I click emergency contact button to jump into the page")]
        public void ThenIClickEmergencyContactButtonToJumpIntoThePage()
        {
            addNewEmergencyContact.ClickEmergencyContactButton();
        }


        [Then(@"I add a new emergency contact to this account")]
        public void ThenIAddANewEmergencyContactToThisAccount()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string FirstName = jsonData.emergencyContact.ElementAt(0).firstName;
            string MiddleName = jsonData.emergencyContact.ElementAt(0).middleName;
            string LastName = jsonData.emergencyContact.ElementAt(0).lastName;
            //string Email = jsonData.emergencyContact.ElementAt(0).email;
            //string Mobile = jsonData.emergencyContact.ElementAt(0).mobile;
            string HomePhoneArea = jsonData.emergencyContact.ElementAt(0).homePhoneArea;
            string HomePhoneNum = jsonData.emergencyContact.ElementAt(0).homePhoneNum;
            string WorkPhoneArea = jsonData.emergencyContact.ElementAt(0).workPhoneArea;
            string WorkPhoneNum = jsonData.emergencyContact.ElementAt(0).workPhoneNum;
            string WorkPhoneExt = jsonData.emergencyContact.ElementAt(0).workPhoneExt;
            string Location = jsonData.emergencyContact.ElementAt(0).location;
            string StreetAddress = jsonData.emergencyContact.ElementAt(0).streetAddress;
            string Suburb = jsonData.emergencyContact.ElementAt(0).suburb;
            string Region = jsonData.emergencyContact.ElementAt(0).region;
            string City = jsonData.emergencyContact.ElementAt(0).city;
            string Country = jsonData.emergencyContact.ElementAt(0).country;
            string PostalCode = jsonData.emergencyContact.ElementAt(0).postalCode;

            addNewEmergencyContact.CreateEmergencyContact(FirstName, MiddleName, LastName, HomePhoneArea, HomePhoneNum, WorkPhoneArea, WorkPhoneNum, WorkPhoneExt, Location, StreetAddress, Suburb, City, Region, Country, PostalCode);
        }

        [Then(@"I should be able to see the save new emergency account message")]
        public void ThenIShouldBeAbleToSeeTheSaveNewEmergencyAccountMessage()
        {
            string expecedMessage = addNewEmergencyContact.AssertMessage();
            Assert.That(expecedMessage == "Data saved successfully", "Actual message and expected message do not match!");
        }

        [Then(@"I click the Customers list and select the attendees option")]
        public void ThenIClickTheCustomersListAndSelectTheAttendeesOption()
        {
            addNewAttendee.SelectAttendeeOption();
        }

        [Then(@"I add a new attendee for this account")]
        public void ThenIAddANewAttendeeForThisAccount()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string Name = jsonData.accountName;
            string FirstName = jsonData.attendeeDetails.ElementAt(0).firstName;
            string MiddleName = jsonData.attendeeDetails.ElementAt(0).middleName;
            string LastName = jsonData.attendeeDetails.ElementAt(0).lastName;
            string KnownAs = jsonData.attendeeDetails.ElementAt(0).knownAs;
            string SchoolYear = jsonData.attendeeDetails.ElementAt(0).schoolYear;
            string SubsidyNumber = jsonData.attendeeDetails.ElementAt(0).subsidyNumber;
            string Location = jsonData.attendeeDetails.ElementAt(0).location;
            string StreetAddress = jsonData.attendeeDetails.ElementAt(0).streetAddress;
            string Suburb = jsonData.attendeeDetails.ElementAt(0).suburb;
            string Region = jsonData.attendeeDetails.ElementAt(0).region;
            string City = jsonData.attendeeDetails.ElementAt(0).city;
            string Country = jsonData.attendeeDetails.ElementAt(0).country;
            string PostalCode = jsonData.attendeeDetails.ElementAt(0).postalCode;
            string Note = jsonData.attendeeDetails.ElementAt(0).note;

            addNewAttendee.CreateNewAttendee(Name, FirstName, MiddleName, LastName, KnownAs, SchoolYear, SubsidyNumber, Location, StreetAddress, Suburb, City, Region, Country, PostalCode, Note);
        }

        [Then(@"I should be able to see new attendee save sucessfull message")]
        public void ThenIShouldBeAbleToSeeNewAttendeeSaveSucessfullMessage()
        {
            string expecedMessage = addNewAttendee.assertAttendeeMessage();
            Assert.That(expecedMessage == "New Attendee Created", "Actual message and expected message do not match!");
        }

        [Then(@"I click the customers list and selece accounts option")]
        public void ThenIClickTheCustomersListAndSeleceAccountsOption()
        {
            addNewAccount.SelectAccountsOption();
        }

        [Then(@"I search account by using search bar")]
        public void ThenISearchAccountByUsingSearchBar()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");
            string Name = jsonData.accountName;

            createAccountProfile.searchAccountProfile(Name);
        }
        

        [Then(@"I fill up the account profile and switch the status")]
        public void ThenIFillUpTheAccountProfileAndSwitchTheStatus()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");
            string NewProfileName = jsonData.profileDetails.ElementAt(0).newProfileName;
            string NewProfileAccountNum = jsonData.profileDetails.ElementAt(0).newProfileAccountNum;


            createAccountProfile.createAccountProfile(NewProfileName, NewProfileAccountNum);
        }


        [Then(@"I selected Customer list and selected the Account option")]
        public void ThenISelectedCustomerListAndSelectedTheAccountOption()
        {
            addNewAccount.SelectAccountsOption();
        }

        [Then(@"I clicked the New Account button and start input the details")]
        public void ThenIClickedTheNewAccountButtonAndStartInputTheDetails()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string Name = jsonData.accountName;
            string AccountNumber = jsonData.accountDetails.ElementAt(1).accountNumber;
            string PrimaryContactFirstName = jsonData.accountDetails.ElementAt(1).firstName;
            string PrimaryContactMiddleName = jsonData.accountDetails.ElementAt(1).middleName;
            string PrimaryContactLastName = jsonData.accountDetails.ElementAt(1).lastName;
            string Email = jsonData.accountDetails.ElementAt(1).email;
            string Mobile = jsonData.accountDetails.ElementAt(1).mobile;
            string HomePhoneAreaCode = jsonData.accountDetails.ElementAt(1).homePhoneAreaCode;
            string HomePhoneLocalNum = jsonData.accountDetails.ElementAt(1).homePhoneLocalNum;
            string WorkPhoneAreaCode = jsonData.accountDetails.ElementAt(1).workPhoneAreaCode;
            string WorkPhoneLocalNum = jsonData.accountDetails.ElementAt(1).workPhoneLocalNum;
            string WorkPhoneExt = jsonData.accountDetails.ElementAt(1).workPhoneExt;
            string PALocation = jsonData.accountDetails.ElementAt(1).paLocation;
            string PAStreetAddress = jsonData.accountDetails.ElementAt(1).paStreetAddress;
            string PASuburb = jsonData.accountDetails.ElementAt(1).paSuburb;
            string PACity = jsonData.accountDetails.ElementAt(1).paCity;
            string PARegion = jsonData.accountDetails.ElementAt(1).paRegion;
            string PACountry = jsonData.accountDetails.ElementAt(1).paCountry;
            string PAPostalCode = jsonData.accountDetails.ElementAt(1).paPostalCode;
            string SubsidyNumber = jsonData.accountDetails.ElementAt(1).subsidynumber;
            string BALocation = jsonData.accountDetails.ElementAt(1).baLocation;
            string BAStreetAddress = jsonData.accountDetails.ElementAt(1).baStreetAddress;
            string BASuburb = jsonData.accountDetails.ElementAt(1).baSuburb;
            string BACity = jsonData.accountDetails.ElementAt(1).baCity;
            string BARegion = jsonData.accountDetails.ElementAt(1).baRegion;
            string BACountry = jsonData.accountDetails.ElementAt(1).baCountry;
            string BAPostalCode = jsonData.accountDetails.ElementAt(1).baPostalCode;

            addNewAccount.CreateNewAccount(Name, AccountNumber, PrimaryContactFirstName, PrimaryContactMiddleName, PrimaryContactLastName, Email, Mobile, HomePhoneAreaCode, HomePhoneLocalNum, WorkPhoneAreaCode, WorkPhoneLocalNum, WorkPhoneExt, PALocation, PAStreetAddress, PASuburb, PACity, PARegion, PACountry, PAPostalCode, SubsidyNumber, BALocation, BAStreetAddress, BASuburb, BACity, BARegion, BACountry, BAPostalCode);
        }

        [Then(@"I should be able to see the new account created message")]
        public void ThenIShouldBeAbleToSeeTheNewAccountCreatedMessage()
        {
            string expecedMessage = addNewAccount.assertAccount();
            Assert.That(expecedMessage == "New Account Created", "Actual message and expected message do not match!");
        }


        [Then(@"I should see the save new profile message showing on the page")]
        public void ThenIShouldSeeTheSaveNewProfileMessageShowingOnThePage()
        {
            string expecedMessage = createAccountProfile.assertMessage();
            Assert.That(expecedMessage == "Data saved successfully", "Actual message and expected message do not match!");
        }

        [Then(@"I add a first emergency contact to this account")]
        public void ThenIAddAFirstEmergencyContactToThisAccount()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string FirstName = jsonData.emergencyContact.ElementAt(1).firstName;
            string MiddleName = jsonData.emergencyContact.ElementAt(1).middleName;
            string LastName = jsonData.emergencyContact.ElementAt(1).lastName;
            string HomePhoneArea = jsonData.emergencyContact.ElementAt(1).homePhoneArea;
            string HomePhoneNum = jsonData.emergencyContact.ElementAt(1).homePhoneNum;
            string WorkPhoneArea = jsonData.emergencyContact.ElementAt(1).workPhoneArea;
            string WorkPhoneNum = jsonData.emergencyContact.ElementAt(1).workPhoneNum;
            string WorkPhoneExt = jsonData.emergencyContact.ElementAt(1).workPhoneExt;
            string Location = jsonData.emergencyContact.ElementAt(1).location;
            string StreetAddress = jsonData.emergencyContact.ElementAt(1).streetAddress;
            string Suburb = jsonData.emergencyContact.ElementAt(1).suburb;
            string Region = jsonData.emergencyContact.ElementAt(1).region;
            string City = jsonData.emergencyContact.ElementAt(1).city;
            string Country = jsonData.emergencyContact.ElementAt(1).country;
            string PostalCode = jsonData.emergencyContact.ElementAt(1).postalCode;

            addSecondNewEmergencyContact.CreateNewEmergencyContact(FirstName, MiddleName, LastName, HomePhoneArea, HomePhoneNum, WorkPhoneArea, WorkPhoneNum, WorkPhoneExt, Location, StreetAddress, Suburb, City, Region, Country, PostalCode);
        }


        [Then(@"I should be able to see the save first emergency account message")]
        public void ThenIShouldBeAbleToSeeTheSaveFirstEmergencyAccountMessage()
        {
            string expecedMessage = addNewEmergencyContact.AssertMessage();
            Assert.That(expecedMessage == "Data saved successfully", "Actual message and expected message do not match!");
        }

        [Then(@"I add a second emergency contact to this account")]
        public void ThenIAddASecondEmergencyContactToThisAccount()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string FirstName = jsonData.emergencyContact.ElementAt(2).firstName;
            string MiddleName = jsonData.emergencyContact.ElementAt(2).middleName;
            string LastName = jsonData.emergencyContact.ElementAt(2).lastName;
            string HomePhoneArea = jsonData.emergencyContact.ElementAt(2).homePhoneArea;
            string HomePhoneNum = jsonData.emergencyContact.ElementAt(2).homePhoneNum;
            string WorkPhoneArea = jsonData.emergencyContact.ElementAt(2).workPhoneArea;
            string WorkPhoneNum = jsonData.emergencyContact.ElementAt(2).workPhoneNum;
            string WorkPhoneExt = jsonData.emergencyContact.ElementAt(2).workPhoneExt;
            string Location = jsonData.emergencyContact.ElementAt(2).location;
            string StreetAddress = jsonData.emergencyContact.ElementAt(2).streetAddress;
            string Suburb = jsonData.emergencyContact.ElementAt(2).suburb;
            string Region = jsonData.emergencyContact.ElementAt(2).region;
            string City = jsonData.emergencyContact.ElementAt(2).city;
            string Country = jsonData.emergencyContact.ElementAt(2).country;
            string PostalCode = jsonData.emergencyContact.ElementAt(2).postalCode;


            addSecondNewEmergencyContact.CreateNewEmergencyContact(FirstName, MiddleName, LastName, HomePhoneArea, HomePhoneNum, WorkPhoneArea, WorkPhoneNum, WorkPhoneExt, Location, StreetAddress, Suburb, City, Region, Country, PostalCode);
        }

        [Then(@"I should be able to see the save second emergency account message again")]
        public void ThenIShouldBeAbleToSeeTheSaveSecondEmergencyAccountMessageAgain()
        {
            string expecedMessage = addNewEmergencyContact.AssertMessage();
            Assert.That(expecedMessage == "Data saved successfully", "Actual message and expected message do not match!");
        }

        [Then(@"I click Profile button jump back to profile page")]
        public void ThenIClickProfileButtonJumpBackToProfilePage()
        {
            createAccountProfile.profilePageButton();
        }


        [Then(@"I fill up the second account profile and switch the status")]
        public void ThenIFillUpTheSecondAccountProfileAndSwitchTheStatus()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");
            string NewProfileName = jsonData.profileDetails.ElementAt(1).newProfileName;
            string NewProfileAccountNum = jsonData.profileDetails.ElementAt(1).newProfileAccountNum;


            createAccountProfile.createAccountProfile(NewProfileName, NewProfileAccountNum);
        }
    }
}
