using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SunblazeFE.PagesSE
{
    public class SeleniumDriver: IDisposable
    {
        public IWebDriver driver;
        public SeleniumDriver()
        {
            driver = new ChromeDriver();
        }
        public void Dispose()
        {
            driver.Quit();
            Console.WriteLine("Driver successfully closed");
        }
        
    }
}
