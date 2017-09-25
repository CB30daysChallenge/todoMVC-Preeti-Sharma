using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using log4net;
using log4net.Config;

namespace ToDoUI.Tests.Models.PageObjects.Base
{
    public class PageBase
    {
        protected IWebDriver wd;
        public PageBase(IWebDriver _el)
        {
            wd = _el;
        }
        public static ILog logger = LogManager.GetLogger(typeof(PageBase));

    }
}
