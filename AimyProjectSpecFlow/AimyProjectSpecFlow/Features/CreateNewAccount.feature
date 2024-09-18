Feature: 02 CreateNewAccount

As a Existing user
I would like to create a new account and fill up all the form
So that my account can be searchable

@RegressionTest_Enrolment
Scenario: 01 Create a new account and fill up Holder, Emergency and Attendee
Given I use existing user credentials to login to portal
When I enter my user name and password
Then I should be able to see the protal page
And I would like to switch the account to Demo unit
Then I select Customer list and select the Account option
And I click the New Account button and start input the details
Then I should see the new account created message
And I add a new account holder to this account
Then I should be able to see the save new account holder message
Then I click emergency contact button to jump into the page
And I add a new emergency contact to this account
Then I should be able to see the save new emergency account message
And I click the Customers list and select the attendees option
Then I add a new attendee for this account
Then I should be able to see new attendee save sucessfull message
Then I click the customers list and selece accounts option
And I search account by using search bar
Then I fill up the account profile and switch the status
Then I should see the save new profile message showing on the page


@RegressionTest_Enrolment
Scenario: 02 Add second emergency contact into the account
Given I use existing user credentials to login to portal
When I enter my user name and password
Then I should be able to see the protal page
Then I selected Customer list and selected the Account option
And I clicked the New Account button and start input the details
Then I should be able to see the new account created message
Then I click emergency contact button to jump into the page
And I add a first emergency contact to this account
Then I should be able to see the save first emergency account message
And I add a second emergency contact to this account
Then I should be able to see the save second emergency account message again
And I click Profile button jump back to profile page
Then I fill up the second account profile and switch the status
Then I should see the save new profile message showing on the page