using AutomationCore.Web;
using Microsoft.Playwright;

namespace Web.Pages.PlaywrightPages
{
    public class PlaywrightPage : BasePage
    {
        public PlaywrightPage(IPage page, string pageUrl) : base(page, pageUrl)
        {

        }

        public override Task WaitForLoading()
        {
            return base.WaitForLoading();
        }
    }
}