using Microsoft.Playwright;
namespace SunblazeFE.PagesPW;

public class PlaywrightDriver : IDisposable
{
    //Create instance of PlayWright Driver(similar to Selenium driver)
    public readonly Task<IPage> _page;
    private IBrowser? _browser;
    public PlaywrightDriver()
    {
        _page = InitializePlaywright();
    }
    //Must be used with .Result so Page can be interacted with when Driver is called
    public IPage Page => _page.Result;
    private async Task<IPage> InitializePlaywright()
    {
        //Playwright
        var playwright = await Playwright.CreateAsync();
        //Browser
        _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        //Page
        return await _browser.NewPageAsync();
    }
    public void Dispose()
    {
        _browser?.CloseAsync();
        Console.WriteLine("Driver successfully closed");
    }
}
