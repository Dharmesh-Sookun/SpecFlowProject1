Feature: ITStockManagement
	As an admin user of the system
	I want to be able to add new suppliers 

Scenario: Adding new supplier
	Given I am on the add new supplier screen
		And I enter the name of the supplier
		And I enter the phone number of the supplier
		And I enter the address of the supplier
	When I click create
	Then I should see a list of all suppliers

