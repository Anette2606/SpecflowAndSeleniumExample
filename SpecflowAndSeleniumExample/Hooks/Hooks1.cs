using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAndSeleniumExample.Drivers;
using TechTalk.SpecFlow;

namespace SpecflowAndSeleniumExample.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly ScenarioContext _scenarioContext;

        public Hooks1(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag()
        {
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver , "SeleniumDriver");
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Selenium WebDriver quit");
            //_scenarioContext.Get<ChromeDriver>("WebDriver").Quit();
        }
    }
}