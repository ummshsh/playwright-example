using Microsoft.Playwright;
using Steps.WebSteps;

namespace Steps.BaseSteps
{
    public class UiSteps
    {
        private readonly IPage _page;

        public PlaywrightPageSteps PlaywrightPage { get; init; }

        public UiSteps(IPage page)
        {
            _page = page;
            PlaywrightPage = new PlaywrightPageSteps(_page);
        }
    }
}
