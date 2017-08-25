using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.Models.PageObjects.Base
{
    public class ProjBase
    {
       public void NavigateToUrl()
        {
            IWebDriver wd = new ChromeDriver();
            wd.Navigate().GoToUrl("http://todomvc.com/examples/react/#/");
            Console.WriteLine("page loaded");
        }
    }
}
