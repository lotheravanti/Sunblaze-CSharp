using Microsoft.Playwright;
namespace SunblazeFE.PagesPW;

public class Homepage
{
    //Call instance of IPage
    public IPage _page;
    //Locators on Homepage
    public ILocator _lnkABTesting => _page.Locator(selector: "text=A/B Testing");
    public ILocator _AddRemove => _page.Locator(selector: "text=Add/Remove Elements");
    public ILocator _lnkBasicAuth => _page.Locator(selector: "text=Basic Auth");
    public ILocator _lnkBrokenImages => _page.Locator(selector: "text=Broken Images");
    public ILocator _lnkChallengingDOM => _page.Locator(selector: "text=Challenging DOM");
    public ILocator _lnkCheckBoxes => _page.Locator(selector: "text=Checkboxes");
    public ILocator _lnkContextMenu => _page.Locator(selector: "text=Context Menu");
    public ILocator _lnkDigestAuthentication => _page.Locator(selector: "text=Digest Authentication");
    public ILocator _lnkDisappearingElements => _page.Locator(selector: "text=Disappearing Elements");
    public ILocator _lnkDragDrop => _page.Locator(selector: "text=Drag and Drop");
    public ILocator _lnkDropdown => _page.Locator(selector: "text=Dropdown");
    public ILocator _lnkDynamicContent => _page.Locator(selector: "text=Dynamic Content");
    public ILocator _lnkDynamicControls => _page.Locator(selector: "text=Dynamic Controls");
    public ILocator _lnkDynamicLoading => _page.Locator(selector: "text=Dynamic Loading");
    public ILocator _lnkEntryAD => _page.Locator(selector: "text=Entry Ad");
    public ILocator _lnkExitIntent => _page.Locator(selector: "text=Exit Intent");
    public ILocator _lnkFileDownload => _page.Locator(selector: "text=File Download");
    public ILocator _lnkFileUpload => _page.Locator(selector: "text=File Upload");
    public ILocator _lnkFloatingMenu => _page.Locator(selector: "text=Floating Menu");
    public ILocator _lnkForgotPassword => _page.Locator(selector: "text=Forgot Password");
    public ILocator _lnkFormAuthentication => _page.Locator(selector: "text=Form Authentication");
    public ILocator _lnkFrames => _page.Locator(selector: "text=Frames");
    public ILocator _lnkGeolocation => _page.Locator(selector: "text=Geolocation");
    public ILocator _lnkHorizontalSlider => _page.Locator(selector: "text=Horizontal Slider");
    public ILocator _lnkHovers => _page.Locator(selector: "text=Hovers");
    public ILocator _lnkInfiniteScroll => _page.Locator(selector: "text=Infinite Scroll");
    public ILocator _lnkInputs => _page.Locator(selector: "text=Inputs");
    public ILocator _lnkJQueryUIMenus => _page.Locator(selector: "text=JQuery UI Menus");
    public ILocator _lnkJavaScriptAlerts => _page.Locator(selector: "text=JavaScript Alerts");
    public ILocator _lnkJavascriptOnloadEventError => _page.Locator(selector: "text=JavaScript onload event error");
    public ILocator _lnkKeyPresses => _page.Locator(selector: "text=Key Presses");
    public ILocator _lnkLargeDeepDOM => _page.Locator(selector: "text=Large & Deep DOM");
    public ILocator _lnkMultipleWindows => _page.Locator(selector: "text=Multiple Windows");
    public ILocator _lnkNestedFrames => _page.Locator(selector: "text=Nested Frames");
    public ILocator _lnkNotificationMessages => _page.Locator(selector: "text=Notification Messages");
    public ILocator _lnkRedirectLink => _page.Locator(selector: "text=Redirect Link");
    public ILocator _lnkSecureFileDownload => _page.Locator(selector: "text=Secure File Download");
    public ILocator _lnkShadowDOM => _page.Locator(selector: "text=Shadow DOM");
    public ILocator _lnkShiftingContent => _page.Locator(selector: "text=Shifting Content");
    public ILocator _lnkSlowResources => _page.Locator(selector: "text=Slow Resources");
    public ILocator _lnkSortableDataTables => _page.Locator(selector: "text=Sortable Data Tables");
    public ILocator _lnkStatusCodes => _page.Locator(selector: "text=Status Codes");
    public ILocator _lnkTypos => _page.Locator(selector: "text=Typos");
    public ILocator _lnkWYSIWYGEditor => _page.Locator(selector: "text=WYSIWYG Editor");
    //Initialize constructor and go to Homepage
    public Homepage(IPage page)
    {
        _page = page;
        _page.GotoAsync(url: "https://the-internet.herokuapp.com/");
    }
}
