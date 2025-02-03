using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class Inputs: Homepage
    {
        IWebDriver driver;
        public By inputNumber = By.XPath("//div/p[text()='Number']/following-sibling::input[1]");
        //Inherit from Homepage Class will initiate its Constructor automatically
        public Inputs(IWebDriver driver): base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            this.driver = driver;
            //Go to Test Page
            base.ClickOn(base._lnkInputs);
        }
    }
}
