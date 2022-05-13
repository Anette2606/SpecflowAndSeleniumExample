using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SpecflowAndSeleniumExample.Drivers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace SpecflowAndSeleniumExample.StepDefinitions
{
    [Binding]
    public class PlayAVideoStepDefinitions
    {

        ChromeDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public PlayAVideoStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to youtube on following enviroment")]
        public void GivenINavigateToYoutubeOnFollowingEnviromet(Table table)
        {
            driver=_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url="https://www.youtube.com/";
        }

        [Given(@"I search for a video")]
        public void GivenISearchForAVideo()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/form/div[1]/div[1]/input")).Click();
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/form/div[1]/div[1]/input")).SendKeys("Cute baby animals Videos Compilation cutest moment of the animals - Cutest Puppies #4");
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/button/yt-icon")).Click();
        }

        [When(@"I click the video")]
        public void WhenIClickTheVideo()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[1]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();
        }

        [Then(@"The video should be played")]
        public void ThenTheVideoShouldBePlayed()
        {
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[1]/div/div/div/ytd-player/div/div/div[23]")).Displayed, Is.EqualTo (true));
        }
    }
}
