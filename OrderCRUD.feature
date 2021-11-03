Feature: OrderCRUD
	Create, Read, Update, Delete  Order with Test Data

Background:
	Given I have entered UserName and Password
	And I Click Login Button
	Then System shoud shows the Login User's Dashboard

Scenario: Create Order
	Given I Navigate to Order Page	
	And I Click Add New Button
	Then I Enter Order Details
	Then I Add Product Detail
	Then I Click Save Order
