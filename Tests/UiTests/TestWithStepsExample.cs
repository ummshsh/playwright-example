using Microsoft.Playwright.NUnit;
using Steps.BaseSteps;

namespace Tests.UiTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class TestWithStepsExample : PageTest
{
    [Test]
    public async Task TestWithPoAndSteps()
    {
        var steps = new UiSteps(Page);
        await steps.PlaywrightPage.Open();
        await steps.PlaywrightPage.Search("Auto-waiting");
        await steps.PlaywrightPage.ClickSearchResult("Auto-waiting");
    }
}