using Steps.BaseSteps;
using Web.Pages.PlaywrightPages;

namespace Steps.WebSteps
{
    [ReportingSteps]
    public class PlaywrightPageSteps
    {
        private PlaywrightPage playwrightPage = new PlaywrightPage(, "https://playwright.dev/dotnet/");

        public async void Open()
        {
            await playwrightPage.Open();
        }
    }
}
