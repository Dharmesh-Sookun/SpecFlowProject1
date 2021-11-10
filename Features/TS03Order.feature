# Test suite for order scenarios
Feature: TS03 Order
	Add order scenarios

Background: 
Given that the login page is displayed

Scenario: SC01 Add order
When I log in as a.b@gmail.com
And I add order
And logged out
When I log in as a.b@gmail.com
Then order should be displayed

Scenario: SC02 Delete order
When I log in as a.b@gmail.com
And I delete order
And logged out
When I log in as a.b@gmail.com
Then order deleted should not be displayed

Scenario: SC03 Update order
When I log in as a.b@gmail.com
And I update order
And logged out
When I log in as a.b@gmail.com
Then order should be updated

Scenario: SC04 View orders
When I log in as a.b@gmail.com
And I view orders
Then all orders should be displayed

Scenario: SC05 View order
When I log in as a.b@gmail.com
And I view one order
Then all details for that order should be displayed