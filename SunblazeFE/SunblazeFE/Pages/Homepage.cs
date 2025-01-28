using Microsoft.Playwright;

namespace SunblazeFE.Pages;

public class Homepage
{
    //Inherit from Page class
    private IPage _page;
    public ILocator _lnkABTesting => _page.Locator(selector: "text=A/B Testing");
    public ILocator _AddRemove => _page.Locator(selector: "text=Add/Remove Elements");
    public ILocator _lnkBasicAuth => _page.Locator(selector: "text=Basic Auth");
    public ILocator _lnkBrokenImages => _page.Locator(selector: "text=");
    public ILocator _lnkChallengingDOM => _page.Locator(selector: "text=");
    public ILocator _lnkCheckBoxes => _page.Locator(selector: "text=");
    public ILocator _lnkContextMenu => _page.Locator(selector: "text=Context Menu");
    public ILocator _lnkDigestAuthentication => _page.Locator(selector: "text=");
    public ILocator _lnkDisappearingElements => _page.Locator(selector: "text=");
    public ILocator _lnkDragDrop => _page.Locator(selector: "text=");
    public ILocator _lnkDropdown => _page.Locator(selector: "text=");
    public ILocator _lnkDynamicContent => _page.Locator(selector: "text=");
    public ILocator _lnkDynamicControls => _page.Locator(selector: "text=");
    public ILocator _lnkDynamicLoading => _page.Locator(selector: "text=");
    public ILocator _lnkEntryAD => _page.Locator(selector: "text=");
    public ILocator _lnkExitIntent => _page.Locator(selector: "text=");
    public ILocator _lnkFileDownload => _page.Locator(selector: "text=");
    public ILocator _lnkFileUpload => _page.Locator(selector: "text=");
    public ILocator _lnkFloatingMenu => _page.Locator(selector: "text=");
    public ILocator _lnkForgotPassword => _page.Locator(selector: "text=");
    public ILocator _lnkFormAuthentication => _page.Locator(selector: "text=");
    public ILocator _lnkFrames => _page.Locator(selector: "text=");
    public ILocator _lnkGeolocation => _page.Locator(selector: "text=");
    public ILocator _lnkHorizontalSlider => _page.Locator(selector: "text=");
    public ILocator _lnkHovers => _page.Locator(selector: "text=");
    public ILocator _lnkInfiniteScroll => _page.Locator(selector: "text=");
    public ILocator _lnkInputs => _page.Locator(selector: "text=");
    public ILocator _lnkJQueryUIMenus => _page.Locator(selector: "text=");
    public ILocator _lnkJavaScriptAlerts => _page.Locator(selector: "text=");
    public ILocator _lnkJavascriptOnloadEventError => _page.Locator(selector: "text=");
    public ILocator _lnkKeyPresses => _page.Locator(selector: "text=");
    public ILocator _lnkLargeDeepDOM => _page.Locator(selector: "text=");
    public ILocator _lnkMultipleWindows => _page.Locator(selector: "text=");
    public ILocator _lnkNestedFrames => _page.Locator(selector: "text=");
    public ILocator _lnkNotificationMessages => _page.Locator(selector: "text=");
    public ILocator _lnkRedirectLink => _page.Locator(selector: "text=");
    public ILocator _lnkSecureFileDownload => _page.Locator(selector: "text=");
    public ILocator _lnkShadowDOM => _page.Locator(selector: "text=");
    public ILocator _lnkShiftingContent => _page.Locator(selector: "text=");
    public ILocator _lnkSlowResources => _page.Locator(selector: "text=");
    public ILocator _lnkSortableDataTables => _page.Locator(selector: "text=");
    public ILocator _lnkStatusCodes => _page.Locator(selector: "text=");
    public ILocator _lnkTypos => _page.Locator(selector: "text=");
    public ILocator _lnkWYSIWYGEditor => _page.Locator(selector: "text=");
    public Homepage(IPage page)
    {
        _page = page;
    }

    //Click link method using ILocator type
    public async Task ClickLink(ILocator _link)
    {
        await _link.ClickAsync();
    }
}
