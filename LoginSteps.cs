using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tools.Automation.Framework.Core;
using Tools.Automation.Framework.Drivers;
using Tools.Automation.Framework.Searcher;
using Tools.Automation.Framework.Waits;
using AILogistic.Test.PageObjects;

namespace AILogistic.Test
{
    [Binding]
    public class LoginSteps : TestCore
    {
        ElementSearcher objElementSearcher ;
        [Given(@"I have entered UserName and Password")]
        public void GivenIHaveEnteredUserNameAndPassword()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            objElementSearcher.FindElementById("username").SendKeys("muhammadhariskhan26@gmail.com");
            objElementSearcher.FindElementById("password").SendKeys("Welcome@123");

        }

        [Given(@"I Click Login Button")]
        public void GivenIClickLoginButton()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            objElementSearcher.FindElementById("LoginSubmit").Click();
        }

        [Then(@"System shoud shows the Login User's Dashboard")]
        public void ThenSystemShoudShowsTheLoginUserSDashboard()
        {
            WaitForStringPresent.DoWait("Dashboard");
        }
    }
}
