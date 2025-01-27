using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace SunblazeFE
{
    public class Playwright
    {
        //Inherit PageTest
        public class PlaywrightTests: PageTest
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public async Task OpenHomepageClickLink()
            {
                //Initialize Playwright example without inheriting PageTest
                //using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
                //Open Chrome
                //await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                //{ Headless = false });
                //Open Page
                //var page = await browser.NewPageAsync();
                await Page.GotoAsync(url: "https://the-internet.herokuapp.com/");
                await Page.ClickAsync(selector: "text=Context Menu");
                //Take Screenshot
                await Page.ScreenshotAsync(new PageScreenshotOptions
                {
                    Path = "../../../Test Run Files/PWOpenHomePageClickLink.jpg"
                });
                //Assert to provide validation that correct page loaded using built in Expect
                await Expect(Page.Locator(selector: "text='Context menu items are custom additions that appear in the right-click menu.'")).ToBeVisibleAsync();
                Thread.Sleep(2000);
            }

            [Test]
            public async Task InputNumber()
            {
                //Open Page
                await Page.GotoAsync(url: "https://the-internet.herokuapp.com/inputs");
                await Page.ClickAsync(selector: "text=Context Menu");
                Thread.Sleep(2000);
            }
        }
    }
}
