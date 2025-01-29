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
            await Page.GotoAsync(url: "https://the-internet.herokuapp.com/");
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
            Thread.Sleep(2000);
        }

        [Test]
        public async Task InputNumber()
        {
            //Open Page
            await Page.ClickAsync(selector: "text=Inputs");
            Thread.Sleep(2000);
        }

        [Test]
        public async Task OpenHomepageClickLinkPOM()
        {
            Homepage homePage = new Homepage(Page);
            await homePage._lnkContextMenu.ClickAsync();
            Thread.Sleep(2000);
        }

        [Test]
        //Wait for Code 200 API response
        public async Task StatusCode200POM()
        {
            Homepage homePage = new Homepage(Page);
            await homePage._lnkStatusCodes.ClickAsync();
            StatusCodes statusCodes = new StatusCodes(Page);
            await Page.RunAndWaitForResponseAsync(async () =>
            {
                await statusCodes._lnkCode200.ClickAsync();
            }, response => response.Url == statusCodes._urlCode200 && response.Status == 200);
            Thread.Sleep(2000);
        }

        [Test]
        //Wait for Code 200 API response
        public async Task StatusCode404POM()
        {
            Homepage homePage = new Homepage(Page);
            await homePage._lnkStatusCodes.ClickAsync();
            StatusCodes statusCodes = new StatusCodes(Page);
            await Page.RunAndWaitForResponseAsync(async () =>
            {
                await statusCodes._lnkCode404.ClickAsync();
            }, response => response.Url == statusCodes._urlCode404 && response.Status == 404);
            Thread.Sleep(2000);
        }
    }
}
