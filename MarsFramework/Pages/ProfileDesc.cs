using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework.Pages
{
    class ProfileDesc
    {
        public ProfileDesc()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        IWebElement NameDrop => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
        IWebElement Fname => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
        IWebElement Lname => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
        IWebElement Save => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));

        IWebElement Avail => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
       // IWebElement Availability => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
        IWebElement Availability => GlobalDefinitions.driver.FindElement(By.Name("availabiltyType"));

        IWebElement Hrs => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
       // IWebElement Hours => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
        IWebElement Hours => GlobalDefinitions.driver.FindElement(By.Name("availabiltyHour"));

        IWebElement ETarget => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
       // IWebElement EarnTarget => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
        IWebElement EarnTarget => GlobalDefinitions.driver.FindElement(By.Name("availabiltyTarget"));

        IWebElement Description => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        IWebElement DescriptionDeta => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        IWebElement Save1 => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));


        internal void profiledata()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Owner\source\repos\marsframework-master\MarsFramework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", "ProfileData");
            NameDrop.Click();
            Fname.Clear();
            Fname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Fname"));
            Lname.Clear();
            Lname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Lname"));
            Assert.IsTrue(Save.Enabled);
            Save.Click();
            GlobalDefinitions.wait(40);
           // Avail.Click();
           // Availability.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Availability"));
           // GlobalDefinitions.wait(90);
           // Hrs.Click();
           // Hours.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Hours"));
           // GlobalDefinitions.wait(90);
           // ETarget.Click();
           // EarnTarget.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget"));
            // Description.Click();
            //Thread.Sleep(5000);
           // DescriptionDeta.Clear();
           // string desc = GlobalDefinitions.ExcelLib.ReadData(2, "DescriptionData");
           // DescriptionDeta.SendKeys(desc);
           // Assert.That(DescriptionDeta.Text, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "DescriptionData")));
           // Assert.IsTrue(Save1.Enabled);
           //  Save1.Click();
        }

    }
}
