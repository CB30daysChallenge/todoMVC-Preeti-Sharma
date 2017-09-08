using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ToDoUI.Tests.Models.PageObjects.Base
{
    public class PageBase
    {
        protected IWebDriver wd;
        public PageBase(IWebDriver _el)
        {
            wd = _el;
        }
        

    }
}
