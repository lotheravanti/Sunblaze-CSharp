using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using SunblazeFE.PagesPW;

namespace SunblazeFE
{
    //Inherit PageTest
    public class PlaywrightTests: PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            //Constructor will go to Homepage when calling class instead
            //await Page.GotoAsync(url: "https://the-internet.herokuapp.com/");
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
            //Set custom timeout for this test
            Page.SetDefaultTimeout(3000);
            await Page.ClickAsync(selector: "text=Context Menu");
            //Take Screenshot
            await Page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "../../../Test Run Files/PWOpenHomePageClickLink.jpg"
            });
            //Assert to provide validation that correct page loaded using built in Expect
            await Expect(Page.Locator(selector: "text='Context menu items are custom additions that appear in the right-click menu.'")).ToBeVisibleAsync();
        }

        [Test]
        public async Task InputNumber()
        {
            await Page.GotoAsync(url: "https://the-internet.herokuapp.com/");
            //Open Page
            await Page.ClickAsync(selector: "text=Inputs");
        }

        [Test]
        public async Task OpenHomepageClickLinkPOM()
        {
            Homepage homePage = new Homepage(Page);
            await homePage._lnkContextMenu.ClickAsync();
        }

        [Test]
        //Wait for Code 200 API response
        public async Task StatusCode200POM()
        {
            StatusCodes statusCodes = new StatusCodes(Page);
            await statusCodes.checkResponse(statusCodes._lnkCode200, statusCodes._urlCode200, 500);
        }

        [Test]
        //Wait for Code 404 API response
        public async Task StatusCode404POM()
        {
            StatusCodes statusCodes = new StatusCodes(Page);
            await statusCodes.checkResponse(statusCodes._lnkCode404, statusCodes._urlCode404, 404);
        }
        //Add a wait at the end of every test for visibility when running manually
        [TearDown]
        public void Dispose()
        {
            Thread.Sleep(2000);
        }
    }
}
