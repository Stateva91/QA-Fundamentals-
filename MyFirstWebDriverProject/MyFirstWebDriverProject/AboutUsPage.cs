// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
internal class AboutUsPage
{
  
    
        //create instance of our browser
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        //Execute before test
        public void Initialize()
        {
            //open browser
            driver.Navigate().GoToUrl("https://softuni.bg");
            //maximiye the browser instance
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyAboutUsPage()
        {
            // click on За Нас- главен елемент
            IWebElement zaNasMain = driver.FindElement(By.CssSelector(".nav-item:nth-child(1) > nav-link > .cell"));
            zaNasMain.Click();
            // click on За Нас- вутрешен елемент
            IWebElement zaNasInternal = driver.FindElement(By.LinkText("За нас"));
            zaNasInternal.Click();
        Assert.AreEqual("За нас", driver.Title);

        }
    public void VerifyAboutUsPage2()
    {
        // click on За Нас- главен елемент
        IWebElement zaNasMain = driver.FindElement(By.CssSelector(".nav-item:nth-child(1) > nav-link > .cell"));
        zaNasMain.Click();
        // click on За Нас- вутрешен елемент
        IWebElement zaNasInternal = driver.FindElement(By.LinkText("За нас"));
        zaNasInternal.Click();
        Assert.AreEqual("За нас", driver.Title);

    }

    [TearDown]

        public void CloseBrowser()
        {
            //close browser
            driver.Quit();
        }
    }
