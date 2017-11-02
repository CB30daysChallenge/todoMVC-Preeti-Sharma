using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.StepDefinition
{
    [Binding]
    public sealed class Hooks : StepsBase
    {
        [BeforeTestRun]

        public static void BeforeTestRun()
        {
            log4net.Config.XmlConfigurator.Configure();

        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            wd = new ChromeDriver();
            wd.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [AfterScenario]
         public void AfterScenario()
         {
            try
            {
                wd.Close();
            } catch
            {
                
            }
         }
    }
}
