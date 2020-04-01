using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework.Pages
{
    class Search
    {
        public Search()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        IWebElement SearchIcon => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='search link icon']"));
        IWebElement AllCategory => GlobalDefinitions.driver.FindElement(By.XPath("//b[contains(text(),'All Categories')]"));

        IWebElement SearchSkillsBox => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='four wide column']//input[@placeholder='Search skills']"));
        IWebElement SearchLink => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='four wide column']//i[@class='search link icon']"));
        IWebElement SearchUser => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Search user']"));

        IWebElement OnlineBtn => GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'Online')]"));
        IWebElement OnsiteBtn => GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'Onsite')]"));
        IWebElement ShowAllBtn => GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'ShowAll')]"));
        IList<IWebElement> SellerInfo => GlobalDefinitions.driver.FindElements(By.XPath("//a[@class='seller-info']"));
        IList<IWebElement> ServiceInfo => GlobalDefinitions.driver.FindElements(By.XPath("//a[@class='service-info']/p"));

        internal void SearchData()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Owner\source\repos\marsframework-master\MarsFramework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", "Search");
            SearchIcon.Click();
            string expectedTitle = "Search";
            string actualTitle = GlobalDefinitions.driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle), "Navigation to Search Page failed");
            AllCategory.Click();
            GlobalDefinitions.wait(30);
            GlobalDefinitions.driver.FindElement(By.XPath("(//a[@role='listitem'])[2]")).Click();
            GlobalDefinitions.wait(90);
            OnlineBtn.Click();
            OnsiteBtn.Click();
            ShowAllBtn.Click();
            GlobalDefinitions.wait(30);
            SearchSkillsBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            SearchLink.Click();
            GlobalDefinitions.wait(60);
             Assert.That(ServiceInfo[0].Text, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));
             GlobalDefinitions.wait(30);
             SearchUser.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "User"));
            SearchUser.SendKeys(Keys.ArrowDown);
            SearchUser.SendKeys(Keys.Enter);
            Assert.That(SellerInfo[0].Text, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "User")));
        }

    }
}
