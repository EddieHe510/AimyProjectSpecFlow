namespace AimyOneLoginTest.TestData.LoginCredential
{
    public class UserData
    {
        // Login details
        public string username { get; set; }
        public string password { get; set; }
        public string accountName { get; set; }
        public List<AccountDetails> accountDetails { get; set; }
        public List<AccountHolder> accountHolder { get; set; }
        public List<EmergencyContact> emergencyContact { get; set; }
        public List<ProfileDetails> profileDetails { get; set; }
        public List<AttendeeDetails> attendeeDetails { get; set; }

        public class AccountDetails
        {
            // Account detials
            public string location { get; set; }
            public string accountNumber { get; set; }
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string mobile { get; set; }
            public string homePhoneAreaCode { get; set; }
            public string homePhoneLocalNum { get; set; }
            public string workPhoneAreaCode { get; set; }
            public string workPhoneLocalNum { get; set; }
            public string workPhoneExt { get; set; }

            // Account Pysical Address
            public string paLocation { get; set; }
            public string paStreetAddress { get; set; }
            public string paSuburb { get; set; }
            public string paCity { get; set; }
            public string paRegion { get; set; }
            public string paCountry { get; set; }
            public string paPostalCode { get; set; }

            // Account Subsidy Number
            public string subsidynumber { get; set; }

            // Account Billing Address
            public string baLocation { get; set; }
            public string baStreetAddress { get; set; }
            public string baSuburb { get; set; }
            public string baCity { get; set; }
            public string baRegion { get; set; }
            public string baCountry { get; set; }
            public string baPostalCode { get; set; }
        }


        public class AccountHolder
        {
            // Account Holder Contact Details
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            //public string email { get; set; }
            //public string payerId { get; set; }
            //public string mobile { get; set; }
            public string homePhoneArea { get; set; }
            public string homePhoneNum { get; set; }
            public string workPhoneArea { get; set; }
            public string workPhoneNum { get; set; }
            public string workPhoneExt { get; set; }
            public string location { get; set; }
            public string streetAddress { get; set; }
            public string suburb { get; set; }
            public string region { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string postalCode { get; set; }
        }

        public class EmergencyContact
        {
            // Account Emergency Contact Details
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            //public string email { get; set; }
            //public string payerId { get; set; }
            //public string mobile { get; set; }
            public string homePhoneArea { get; set; }
            public string homePhoneNum { get; set; }
            public string workPhoneArea { get; set; }
            public string workPhoneNum { get; set; }
            public string workPhoneExt { get; set; }
            public string location { get; set; }
            public string streetAddress { get; set; }
            public string suburb { get; set; }
            public string region { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string postalCode { get; set; }
        }

        public class ProfileDetails
        {
            // Account Profile Details
            public string newProfileName { get; set; }
            public string newProfileAccountNum { get; set; }
        }

        public class AttendeeDetails
        {
            // Attendee detials
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string knownAs { get; set; }
            public string schoolYear { get; set; }
            public string subsidyNumber { get; set; }
            public string location { get; set; }
            public string streetAddress { get; set; }
            public string suburb { get; set; }
            public string region { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string postalCode { get; set; }
            public string note { get; set; }
        }
    }
}
