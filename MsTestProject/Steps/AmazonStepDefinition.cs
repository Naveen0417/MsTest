using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MsTestProject.Steps
{
    [Binding]
    public sealed class AmazonStepDefinition
    {
        public IWebDriver driver;

        
        [Given(@"open Amazon urland close it")]
        public void GivenOpenAmazonUrlandCloseIt()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://activityvue.gcu.edu/user/Arianna.SaenzOchoa#");           
           
           // driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("IPhone");
            Thread.Sleep(2000);
            driver.Quit();
        }


    }
}
