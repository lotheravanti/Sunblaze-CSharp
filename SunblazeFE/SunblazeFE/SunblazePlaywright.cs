using Microsoft.Playwright;
using NUnit.Framework;

namespace SunblazeFE
{
    public class Playwright
    {
        public class PlaywrightTests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public async Task OpenHomepageClickLink()
            {

                //Initialize Playwright
                using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
                //Open Chrome
                await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                { Headless = false });
                //Open Page
                var page = await browser.NewPageAsync();
                await page.GotoAsync(url: "https://the-internet.herokuapp.com/");
                await page.ClickAsync(selector: "text=Context Menu");
                Thread.Sleep(2000);

            }
        }
    }
}
