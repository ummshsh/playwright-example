using AutomationCore.Web;
using Microsoft.Playwright;

namespace Web.Pages.PlaywrightPages
{
    public class PlaywrightPage : BasePage
    {
        public PlaywrightPageHeader PlaywrightPageHeader { get; init; }

        public PlaywrightPage(IPage page) : base(page, "https://playwright.dev/dotnet/")
        {
            PlaywrightPageHeader = new PlaywrightPageHeader(page);
        }

        public override Task WaitForLoading()
        {
            return Task.CompletedTask;
        }
    }
}