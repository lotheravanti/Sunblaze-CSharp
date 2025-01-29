﻿using Microsoft.Playwright;

namespace SunblazeFE.PagesPW;

public class StatusCodes
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
    //Constructor will go to Homepage and then Test Page
    public StatusCodes(IPage page)
    {
        _page = page;
        Homepage homePage = new Homepage(_page);
        homePage._lnkStatusCodes.ClickAsync();
    }
}
