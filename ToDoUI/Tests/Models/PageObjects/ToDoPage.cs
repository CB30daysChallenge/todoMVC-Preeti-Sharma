using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToDoUI.Tests.Models.PageObjects.Base;
using NUnit.Framework;

namespace ToDoUI.Tests.Models.PageObjects
{
   public class ToDoPage:PageBase
    {
        public ToDoPage(IWebDriver _el) : base(_el)
        {
        }

        public void NavigateToUrl()
        {   
            wd.Navigate().GoToUrl("http://todomvc.com/examples/react/#/");
            Console.WriteLine("page loaded");
        }

        public void EnterItem(string itemtext)
        {
            IWebElement textbox;
            try
            {
                textbox = wd.FindElement(By.XPath("/html/body/section/div/header/input"));
            }
            catch (Exception e)
            {
                Console.WriteLine("textbox not found");
                throw (e);
            }
            textbox.SendKeys(itemtext);



        }

        public void PressReturn()
        {
            IWebElement textbox = wd.FindElement(By.XPath("/html/body/section/div/header/input"));
            textbox.SendKeys(Keys.Return);
        }

        public Boolean AddedItem(string text_add)
        {
            Assert.IsTrue(wd.PageSource.Contains(text_add));
            return true;
        }

        public void SeeCheckbox()
        {
            bool present;
            try
            {
                wd.FindElement(By.XPath("/html/body/section/div/section/ul/li[2]/div/input"));
                present = true;
            }
            catch (NoSuchElementException e)
            {
                present = false;
            }
        }
    }
}
