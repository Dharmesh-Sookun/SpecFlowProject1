# Test suite for stock scenarios
Feature: TS01 Stock
	Add stock scenarios

Background: 
Given that the login page is displayed

Scenario: SC01 Add stock
When I log in as a.b@gmail.com
And I add stock
Then stock should be displayed

Scenario: SC02 Delete stock
When I log in as admin
And I delete stock
Then stock deleted should not be displayed

Scenario: SC03 Update stock
When I log in as admin
And I update stock
Then stock should be updated

Scenario: SC04 View stocks
When I log in as admin
And I view stocks
Then all stocks should be displayed

Scenario: SC05 View stock
When I log in as admin
And I view one stock
Then all details for that stock should be displayed