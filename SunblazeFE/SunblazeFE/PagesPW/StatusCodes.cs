using Microsoft.Playwright;

namespace SunblazeFE.PagesPW;

public class StatusCodes: Homepage
{
    //Call instance of IPage
    private IPage _page;
    //Initialize constructor(shorter form) and inherit from IPage class
    //public StatusCodes(IPage page) => _page = page;
    //Locators on Homepage
    public ILocator _lnkCode200 => _page.Locator(selector: "text=200");
    public String _urlCode200 => "https://the-internet.herokuapp.com/status_codes/200";
    public ILocator _lnkCode301 => _page.Locator(selector: "text=301");
    public String _urlCode404 => "https://the-internet.herokuapp.com/status_codes/404";
    public ILocator _lnkCode404 => _page.Locator(selector: "text=404");
    public ILocator _lnkCode500 => _page.Locator(selector: "text=500");
    public async Task checkResponse(ILocator lnkCode, String urlCode, int code)
    {
        await _page.RunAndWaitForResponseAsync(async () =>
        {
            //Action to be performed
            await lnkCode.ClickAsync();
            //Response conditions
        }, response => response.Url == urlCode && response.Status == code);
    }
    //Inherit from Homepage Class will initiate its Constructor automatically
    public StatusCodes(IPage page): base(page)
    {
        _page = page;
        //Go to Test Page
        base._lnkStatusCodes.ClickAsync();
    }
}
