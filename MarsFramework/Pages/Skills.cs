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
    class Skills
    {
        public Skills()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        public void addskills()
        {
            Details addlang = new Details();
            addlang.AddLanguage();
            Thread.Sleep(1000);
            addlang.UpdateLanguage();
            Thread.Sleep(1000);
            addlang.DeleteLanguage();
            addlang.AddSkill();
            addlang.UpdateSkill();
            addlang.DeleteSkill();
            addlang.AddCertification();
            Thread.Sleep(1000);
            addlang.UpdateCertification();
            Thread.Sleep(1000);
            addlang.DeleteCertification();
        }
    }
}
