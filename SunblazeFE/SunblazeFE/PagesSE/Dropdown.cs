using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class Dropdown : Homepage
    {
        IWebDriver driver;
        public By dropdownField = By.Id("dropdown");
        //Inherit from Homepage Class will initiate its Constructor automatically
        public Dropdown(IWebDriver driver) : base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            this.driver = driver;
            //Go to Test Page
            base.ClickOn(base._lnkDropdown);
        }
    }
}
