using Mars_HannahN.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_HannahN.Utils;

namespace Mars_HannahN.Tests
{
    internal class Language_Tests : CommonDriver

    {
        //IWebDriver driver;
        LoginPage loginPageObj = new LoginPage();
        LanguagePage languagePageObj = new LanguagePage();

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
        public void addLanguageTest()
        {
            languagePageObj.addLanguage(driver);
        }

        [Test, Order(2)]
        public void cancelUpdateLanguageTest()
        {
            languagePageObj.cancelUpdateLanguage(driver);
        }

        [Test, Order(3)]
        public void updateLanguageTest()
        {
            languagePageObj.updateLanguage(driver);
        }


        [Test, Order(4)]
        public void deleteLanguageTest()
        {
            languagePageObj.deleteLanguage(driver);
        }

    }
}

