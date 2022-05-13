using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAndSeleniumExample.Drivers
{
    public class SeleniumDriver
    {
        private ChromeDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenarioContext= scenarioContext;

        public ChromeDriver Setup()
        {
            var chromeOptions = new ChromeOptions();


            driver= new ChromeDriver(chromeOptions);
            _scenarioContext.Set(driver,"WebDriver");
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
