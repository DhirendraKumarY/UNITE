using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
namespace SimpleUnitTestSpecFlow.StepDefinationFiles
{
    [Binding]
    public class SearchLetterSteps
    {

        public IWebDriver driver;
        [Given(@"Launch Google Chrome")]
        public void GivenLaunchGoogleChrome()
        {
            Console.WriteLine("Simple Selenium Examples");
            driver = new ChromeDriver();
        }

        [Given(@"Navigate Google URL")]
        public void GivenNavigateGoogleURL()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [When(@"Typed for search letter")]
        public void WhenTypedForSearchLetter()
        {
            driver.FindElement(By.Name("q")).SendKeys("Dhirendra Kumar Communication " + Keys.Enter);
        }

        [Then(@"Google has searced and quit")]
        public void ThenGoogleHasSearcedAndQuit()
        {
            driver.Quit();
        }
    }
}
