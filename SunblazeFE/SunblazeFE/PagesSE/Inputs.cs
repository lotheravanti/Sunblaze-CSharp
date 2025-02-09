using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class Inputs: Homepage
    {
        private readonly IWebDriver _driver;
        public By inputNumber = By.XPath("//div/p[text()='Number']/following-sibling::input[1]");
        //Inherit from Homepage Class will initiate its Constructor automatically
        public Inputs(IWebDriver driver): base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            _driver = driver;
            //Go to Test Page
            _driver.FindElement(_lnkInputs).Click();
        }
    }
}
