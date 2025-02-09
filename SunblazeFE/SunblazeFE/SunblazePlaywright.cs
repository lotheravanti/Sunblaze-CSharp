using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using SunblazeFE.PagesPW;

namespace SunblazeFE
{
    //Inherit PageTest for Expect methods
    public class PlaywrightTests: PageTest
    {
        IPage _page;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Starting Tests");
            PlaywrightDriver _driver = new();
            //Assign outer _page that will be used in tests to inner Page from PlaywrightDriver class
            _page = _driver.Page;
        }

        [Test]
        public async Task InputNumberPOM()
        {
            Inputs inputsPage = new(_page);
            await Expect(inputsPage._inputNumber).ToBeVisibleAsync();
        }

        [Test]
        public async Task OpenHomepageClickLinkPOM()
        {
            Homepage homePage = new(_page);
            //Set custom timeout for this test
            _page.SetDefaultTimeout(3000);
            //Verify Home Page loaded
            await Expect(homePage._txtHomePagetitle).ToBeVisibleAsync();
            //Take Screenshot
            await _page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "../../../Test Run Files/PWOpenHomePageClickLink.jpg"
            });
        }

        [Test]
        //Wait for Code 200 API response
        public async Task StatusCode200POM()
        {
            StatusCodes statusCodes = new(_page);
            await statusCodes.checkResponse(statusCodes._lnkCode200, statusCodes._urlCode200, 200);
        }

        [Test]
        //Wait for Code 404 API response
        public async Task StatusCode404POM()
        {
            StatusCodes statusCodes = new(_page);
            await statusCodes.checkResponse(statusCodes._lnkCode404, statusCodes._urlCode404, 404);
        }
        //Add a wait at the end of every test for visibility when running manually
        [TearDown]
        public void Dispose()
        {
            Thread.Sleep(2000);
            _page.CloseAsync();
            Console.WriteLine("Test(s) completed");
        }
    }
}
