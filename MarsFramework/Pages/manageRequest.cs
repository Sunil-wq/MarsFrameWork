using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class manageRequest
    {
        public manageRequest()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        IWebElement MangeRequest => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[1]"));

        IWebElement ReceiveRequest => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Received Requests')]"));

        IWebElement SendRequest => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Sent Requests')]"));

        internal void Request()
        {
            GlobalDefinitions.wait(50);
            MangeRequest.Click();
            // GlobalDefinitions.wait(50);
            MangeRequest.SendKeys(Keys.ArrowDown);
            ReceiveRequest.Click();
           // GlobalDefinitions.wait(50);
            string expectedTitle = "ReceivedRequest";
            string actualTitle = GlobalDefinitions.driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle), "Navigation to ReceivedRequest Page failed");
            GlobalDefinitions.wait(50);
            IWebElement Mor = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='received-request-section']/section[1]/div/div[1]"));
            Mor.Click();
            GlobalDefinitions.wait(50);
            Mor.SendKeys(Keys.ArrowDown);
            Mor.SendKeys(Keys.ArrowDown);
            GlobalDefinitions.wait(50);
            SendRequest.Click();
            GlobalDefinitions.wait(50);
            string Arg = "Devlopment";
            for (int i=1; i<6; i++)
            {
                
                IWebElement Sun = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[2]/a"));
                if(Arg==Sun.Text)
                {
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[2]/a")).Click();
                    return;
                }
            }

        }
    }
}
