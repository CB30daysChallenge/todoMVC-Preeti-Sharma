using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.StepDefinition
{
    public class StepsBase
    {
        protected IWebDriver wd
        {
            get { return (IWebDriver)ScenarioContext.Current["Driver"]; }
            set { ScenarioContext.Current["Driver"] = value; }
        }
    }
}
    