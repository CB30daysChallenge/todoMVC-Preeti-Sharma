Feature: Add Item

Scenario: add item
Given I load the page http://todomvc.com/examples/react/#/ 
When I type some text inside the textbox
And I press enter
Then I see the text added as a list item
And I see a checkbox added in front of the list item
