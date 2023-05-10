using Microsoft.Playwright.NUnit;
using Web.Pages.PlaywrightPages;

namespace Tests.UiTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class TestPageObjectExample : PageTest
{
    [Test]
    public async Task ExamplePageObjectTest()
    {
        var page = new PlaywrightPage(Page);
        await page.Open();
        await page.PlaywrightPageHeader.ClickSearch();
        await page.PlaywrightPageHeader.SearchPopup.InputInSearch("wait");
    }

    [Test]
    public async Task TestWithCodeConfig()
    {
        //using (var playwright = await Playwright.CreateAsync())
        //{
        //    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //    {
        //        Headless = false,
        //        SlowMo = 1,
        //    });
        //var isolatedPage = await browser.NewPageAsync();
        //}
    }
}