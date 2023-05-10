using AutomationCore.Web.Elements;
using Microsoft.Playwright;

namespace Web.Pages.PlaywrightPages
{
    public class PlaywrightPageSearchPopup : WebBlock
    {
        private readonly ILocator _searchTermInput;

        public PlaywrightPageSearchPopup(IPage page) : base(page, page.Locator(".DocSearch-Modal"))
        {
            _searchTermInput = Self.Locator(".DocSearch-Input");
        }

        public async Task InputInSearch(string searchTerm)
        {
            await _searchTermInput.FillAsync(searchTerm);
        }

        public async Task ClickResult(string searchResult)
        {
            await Self.GetByText(searchResult).ClickAsync();
        }
    }
}
