﻿namespace playwright_TravelCounsellors_Test.PlaywrightCode;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class MyTest : PageTest
{
    [Test]
    public async Task ShouldHaveTheCorrectSlogan()
    {
        await Page.GotoAsync("https://playwright.dev");
        await Expect(Page.Locator("text=enables reliable end-to-end testing for modern web apps")).ToBeVisibleAsync();
    }

    [Test]
    public async Task ShouldHaveTheCorrectTitle()
    {
        await Page.GotoAsync("https://playwright.dev");
        var title = Page.Locator(".navbar__inner .navbar__title");
        await Expect(title).ToHaveTextAsync("Playwright");
    }
}
