# Test suite for user scenarios
Feature: TS04 User
	Add user scenarios

Background: 
Given that the login page is displayed

Scenario: SC01 Add user
When I log in as a.b@gmail.com
And I add user
Then user should be displayed

Scenario: SC02 Delete user
When I log in as a.b@gmail.com
And I delete user
Then user deleted should not be displayed

Scenario: SC03 Update user
When I log in as a.b@gmail.com
And I update user
Then user should be updated

Scenario: SC04 View users
When I log in as a.b@gmail.com
And I view users
Then all users should be displayed

Scenario: SC05 View user
When I log in as a.b@gmail.com
And I view one user
Then all details for that user should be displayed