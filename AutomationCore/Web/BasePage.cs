using Microsoft.Playwright;

namespace AutomationCore.Web
{
    public abstract class BasePage
    {
        private readonly IPage _page;
        private readonly string pageUrl;

        public BasePage(IPage page, string pageUrl)
        {
            _page = page;
            this.pageUrl = pageUrl;
        }

        public async Task Open()
        {
            await _page.GotoAsync(pageUrl);
            await WaitForLoading();
        }

        public virtual Task WaitForLoading()
        {
            throw new NotImplementedException("Implement waiter for your page");
        }
    }
}
