using System;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.StepDefinition
{
    [Binding]
    public class PageViewSteps : Models.PageObjects.Base.ProjBase
    {
        [Given(@"I enter http://todomvc.com/examples/react/#/ in the address bar")]
        public void GivenIEnterHttpTodomvc_ComExamplesReactInTheAddressBar()
        {
            NavigateToUrl();
        }
        
        [When(@"the page loads")]
        public void WhenThePageLoads()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see a text box with a placeholder text ""(.*)""")]
        public void ThenISeeATextBoxWithAPlaceholderText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
