Feature: 03 Booking

As a Existing user
I would like to book a class for my attendee
So that my check the booking manager to see my attendee class

@RegressionTest_Booking
Scenario: Existing user tying to book a class for the attendee and validate in booking manager
Given I use this valid credentials json file to login the protal
Then I enter valid username and valid password
Then I should be able to see my account username showing on the profile page
And I would like to switch my account to Demo unit
And I start using booking system to book an class for my attendee
When I click the go to Booking Mangaer button after submited an class
Then I go to booking manager page to validate my attendee program
Then I back to booking page and book an same class for my second attendee
And I click the go to booking manager button and I should see two attendee in same class