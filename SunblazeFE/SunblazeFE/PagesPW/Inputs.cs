using Microsoft.Playwright;
namespace SunblazeFE.PagesPW;

public class Inputs : Homepage
{
    private readonly IPage _page;
    public ILocator _inputNumber => _page.Locator(selector: "xpath=//div/p[text()='Number']/following-sibling::input[1]");
    //Inherit from Homepage Class will initiate its Constructor automatically
    public Inputs(IPage page) : base(page)
    {
        _page = page;
        //Go to Test Page
        base._lnkInputs.ClickAsync();
    }
}
