Feature: TM

Scenario: Verify able to create time record
Given I navigate to the TurnUp Portal at 'http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f'
When I login to the TurnUp Portal with username 'hari' and password '123123'
Then I verify 'hari' Logged in on the Dashboard page
When I click option "Time & Materials" under Administration Drop Down on the dashboard Page
Then I navigate to Index page successfully
When I click CreateNew button
Then I navigate to Edit Page successfully
When I enter the following details and click Save:
| dropdown | code   | price | description |
| Time     | 123123 | 2.00  | Random      |
Then I get routed to Index page successfully
When I click on Last Page sign
Then I am able to validate the entered record.