Feature: PageView

Scenario: PageView
Given I enter http://todomvc.com/examples/react/#/ in the address bar
When the page loads
Then I see a text box with a placeholder text "What needs to be done?"
