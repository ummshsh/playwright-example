using Microsoft.Playwright;
using Steps.BaseSteps;
using Web.Pages.PlaywrightPages;

namespace Steps.WebSteps
{
    ////[ReportingSteps]
    public class PlaywrightPageSteps
    {
        private PlaywrightPage playwrightPage { get; init; }

        public PlaywrightPageSteps(IPage page)
        {
            playwrightPage = new PlaywrightPage(page);
        }

        public async Task Open()
        {
            await playwrightPage.Open();
        }

        public async Task Search(string searchTerm)
        {
            await playwrightPage.PlaywrightPageHeader.ClickSearch();
            await playwrightPage.PlaywrightPageHeader.SearchPopup.InputInSearch(searchTerm);
        }

        public async Task ClickSearchResult(string searchResult)
        {
            await playwrightPage.PlaywrightPageHeader.SearchPopup.ClickResult(searchResult);
        }
    }
}
