using System;
using TechTalk.SpecFlow;
using ToDoUI.Tests.Models.PageObjects;

namespace ToDoUI.Tests.StepDefinition
{
    [Binding]
    public class PageViewSteps : StepsBase
    {
        ToDoPage ToDo;
        [Given(@"I load the page http://todomvc.com/examples/react/#/")]
        public void GivenILoadThePageHttpTodomvc_ComExamplesReact()
        {
            ToDo = new ToDoPage(wd);
            ToDo.NavigateToUrl();
        }

        [When(@"I type some text inside the textbox")]
        public void WhenITypeSomeTextInsideTheTextbox()
        {
            ToDo = new ToDoPage(wd);
            string itemtext = "item1";
            ToDo.EnterItem(itemtext);
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            ToDo = new ToDoPage(wd);
            ToDo.PressReturn();
        }

        [Then(@"I see the text added as a list item")]
        public void ThenISeeTheTextAddedAsAListItem()
        {
            ToDo = new ToDoPage(wd);
            string addedtext = "item1";
            ToDo.AddedItem(addedtext);
        }

        [Then(@"I see a checkbox added in front of the list item")]
        public void ThenISeeACheckboxAddedInFrontOfTheListItem()
        {
            ToDo = new ToDoPage(wd);
            ToDo.SeeCheckbox();
        }

    }
}
