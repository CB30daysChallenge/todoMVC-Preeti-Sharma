using System;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.StepDefinition
{
    [Binding]
    public class PageViewSteps : Models.PageObjects.Base.ProjBase
    {
        [Given(@"I load the page http://todomvc.com/examples/react/#/")]
        public void GivenILoadThePageHttpTodomvc_ComExamplesReact()
        {
            NavigateToUrl();
        }

        [When(@"I type some text inside the textbox")]
        public void WhenITypeSomeTextInsideTheTextbox()
        {
            string itemtext = "item1";
            EnterItem(itemtext);
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            PressReturn();
        }

        [Then(@"I see the text added as a list item")]
        public void ThenISeeTheTextAddedAsAListItem()
        {
            string addedtext = "item1";
            AddedItem(addedtext);
        }

        [Then(@"I see a checkbox added in front of the list item")]
        public void ThenISeeACheckboxAddedInFrontOfTheListItem()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
