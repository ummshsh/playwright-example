using Microsoft.Playwright;

namespace AutomationCore.Web
{
    public abstract class BasePage
    {
        private readonly IPage _page;

        public string PageUrl { get; init; }

        protected BasePage(IPage page, string pageUrl)
        {
            _page = page;
            PageUrl = pageUrl;
        }

        public async Task Open()
        {
            await _page.GotoAsync(PageUrl);
            await WaitForLoading();
        }

        public virtual Task WaitForLoading()
        {
            throw new NotImplementedException("Implement waiter for your page");
        }
    }
}
