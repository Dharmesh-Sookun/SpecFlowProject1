# Test suite for supplier scenarios
Feature: TS02 Supplier
	Add supplier scenarios

Background: 
Given that the login page is displayed

Scenario: SC01 Add supplier
When I log in as a.b@gmail.com
And I add supplier
Then supplier should be displayed

Scenario: SC02 Delete supplier
When I log in as a.b@gmail.com
And I delete supplier 27
Then supplier deleted should not be displayed

Scenario: SC03 Update supplier
When I log in as a.b@gmail.com
And I update supplier 10
Then supplier should be updated 10

Scenario: SC04 View suppliers
When I log in as a.b@gmail.com
And I view suppliers
Then all suppliers should be displayed

Scenario: SC05 View supplier
When I log in as a.b@gmail.com
And I view one supplier 10
Then all details for that supplier should be displayed 10

