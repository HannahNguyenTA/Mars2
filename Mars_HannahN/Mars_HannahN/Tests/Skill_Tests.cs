using Mars_HannahN.Pages;
using Mars_HannahN.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_HannahN.Tests
{
    internal class Skill_Tests : CommonDriver
    {
        //IWebDriver driver;
        LoginPage loginPageObj = new LoginPage();
        SkillPage skillPageObj = new SkillPage();

        [SetUp]
        public void setUp()
        {
            // Prerequisites
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            loginPageObj.loginPage(driver);
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }

        [Test, Order(1)]
        public void addSkillTest()
        {
            skillPageObj.addSkill(driver);
        }


        [Test, Order(2)]
        public void cancelUpdateSkillTest()
        {
            skillPageObj.cancelUpdateSkill(driver);
        }

        [Test, Order(3)]
        public void updateSkillTest()
        {
            skillPageObj.updateSkill(driver);
        }

        [Test, Order(4)]
        public void deleteSkillTest()
        {
            skillPageObj.deleteSkill(driver);
        }


    }
}

    

