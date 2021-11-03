Feature: Login
	Login the given user and check validation of the user

Scenario: Login application with User and Password
	Given I have entered UserName and Password
	And I Click Login Button
	Then System shoud shows the Login User's Dashboard
	