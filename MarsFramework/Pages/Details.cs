using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Details
    {
        public Details()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        IList<IWebElement> rowtable => GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[1]/td[1]"));
        IList<IWebElement> rowtable1 => GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[1]/td[1]"));
        IList<IWebElement> rowtable2 => GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
        public void AddLanguage()
        {
            if (rowtable.Count < 4)
            {
                //Click on Add New button
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

                //Add Language
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("spanish");

                //Click on Language Level
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

                //Choose the language level
                IWebElement Lang = GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
                Lang.Click();

                //Click on Add button
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
                String brg = "spanish";


                for (int j = 0; j < rowtable.Count; j++)
                {

                    int i = j + 1;


                    if (rowtable[j].Text == brg)
                    {
                        IWebElement san = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                        Assert.IsTrue(san.Displayed);
                    }
                }

            }

        }
        public void UpdateLanguage()
        {
            String brg = "spanish";


            for (int j = 0; j < rowtable.Count; j++)
            {

                int i = j + 1;


                if (rowtable[j].Text == brg)
                {

                    GlobalDefinitions.wait(20);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();
                    GlobalDefinitions.wait(20);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).Clear();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys("koren");
                    IWebElement Arg = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[3]"));
                    Arg.Click();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    //GlobalDefinitions.wait(100);
                    Thread.Sleep(2000);
                    IWebElement Ele = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    Assert.IsTrue(Ele.Displayed);
                    

                        
                }
            }
        }
        public void DeleteLanguage()
        {
            String arg = "koren";
            for (int j = 0; j < rowtable.Count; j++)
            {
                int i = j + 1;
                if (rowtable[j].Text == arg)
                {
                    Thread.Sleep(2000);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                    
                }
            }

        }


        public void AddSkill()
        {
            if (rowtable1.Count < 4)
            {
                GlobalDefinitions.wait(50);
                // Click on Profile tab
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
                //Click on add new button
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
                //Add Skill
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("ISTQB");
                //Click on Skill Level
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
                //Choose skill level
                IWebElement Nan = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
                Nan.Click();
                //Click add button
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

                String arg = "ISTQB";
                for (int j = 0; j < rowtable1.Count; j++)
                {
                    int i = j + 1;
                    if (rowtable1[j].Text == arg)
                    {

                        IWebElement Sun = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                        Assert.IsTrue(Sun.Displayed);
                        return;
                    }

                }
            }


        }

        public void UpdateSkill()
        {
            GlobalDefinitions.wait(50);
            // Click on Profile tab
            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            String brg = "ISTQB";


            for (int j = 0; j < rowtable1.Count; j++)
            {

                int i = j + 1;


                if (rowtable1[j].Text == brg)
                {

                    GlobalDefinitions.wait(50); ;
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();
                    GlobalDefinitions.wait(50);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).Clear();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys("IISTQB");
                    IWebElement Arg = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[3]"));
                    Arg.Click();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    Thread.Sleep(2000);
                    IWebElement Sun = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    Assert.IsTrue(Sun.Displayed);
                    return;
                }
            }
        }
        public void DeleteSkill()
        {
            GlobalDefinitions.wait(50);
            // Click on Profile tab
            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            String arg = "IISTQB";
            for (int j = 0; j < rowtable1.Count; j++)
            {
                int i = j + 1;
                if (rowtable1[j].Text == arg)
                {
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                }
            }
        }

        public void AddCertification()
        {
            if (rowtable2.Count < 4)
            {
                GlobalDefinitions.wait(50);
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
                //Click on add new button
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
                //Add certificate
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("SyssOps");
                //Certificate Obtained
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("AWS");
                //Choose Year
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
                //Enter Year
                IWebElement ali = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
                ali.Click();
                //Click Add
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
                String arg = "SyssOps";
                for (int j = 0; j < rowtable2.Count; j++)
                {
                    int i = j + 1;
                    if (rowtable2[j].Text == arg)
                    {
                        IWebElement All = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                        Assert.IsTrue(All.Displayed);
                        return;
                    }

                }


            }


        }
        public void UpdateCertification()
        {
            GlobalDefinitions.wait(50);
            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            String brg = "SyssOps";


            for (int j = 0; j < rowtable2.Count; j++)
            {

                int i = j + 1;


                if (rowtable2[j].Text == brg)
                {
                    GlobalDefinitions.wait(50);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[1]/i")).Click();
                    GlobalDefinitions.wait(50);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input")).Clear();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input")).SendKeys("Devops");
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input")).Clear();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input")).SendKeys("ABS");
                    IWebElement Arg = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select/option[5]"));
                    Arg.Click();
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    IWebElement All = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    Assert.IsTrue(All.Displayed);
                    return;
                }
            }
        }

        public void DeleteCertification()
        {
            GlobalDefinitions.wait(50);
            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            String arg = "Devops";
            for (int j = 0; j < rowtable2.Count; j++)
            {
                int i = j + 1;
                if (rowtable2[j].Text == arg)
                {
                    GlobalDefinitions.wait(50);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + " ]/tr/td[4]/span[2]/i")).Click();
                }
            }
        }

























    }
    
    }

