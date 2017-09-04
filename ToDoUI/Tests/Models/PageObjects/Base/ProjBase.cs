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
        IWebDriver wd = new ChromeDriver();
        public void NavigateToUrl()
        {
            
            wd.Navigate().GoToUrl("http://todomvc.com/examples/react/#/");
            Console.WriteLine("page loaded");
        }

        public void EnterItem(string itemtext)
        {
            IWebElement textbox = wd.FindElement(By.ClassName("new-todo"));
            textbox.SendKeys(itemtext);
        }

        public void PressReturn()
        {
            IWebElement textbox = wd.FindElement(By.ClassName("new-todo"));
            textbox.SendKeys(Keys.Return);
        }

        public void AddedText()
        {

        }
    }
}
