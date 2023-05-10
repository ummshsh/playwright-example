using AutomationCore.Web.Elements;
using Microsoft.Playwright;

namespace Web.Pages.PlaywrightPages
{
    public class PlaywrightPageHeader : WebBlock
    {
        public ILocator SearchButton;

        public PlaywrightPageSearchPopup SearchPopup { get; init; }

        public PlaywrightPageHeader(IPage page) : base(page, page.Locator("[aria-label='Main']"))
        {
            SearchButton = Self.Locator(".searchBox_ZlJk");
            SearchPopup = new PlaywrightPageSearchPopup(ParentPage);
        }

        public async Task ClickSearch()
        {
            await SearchButton.WaitForAsync();
            await SearchButton.ClickAsync();
        }
    }
}
