using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Playwright;
using ServiceStack.Host;
using SpecFlow.Actions.Playwright;
using static ClassConfiguration.Config;

namespace playwright_TravelCounsellors_Test.PlaywrightCode
{
    [Binding]
    public class ClassTravelCounsellor : PageTest
    {
        // [OneTimeSetUp]
        // public static async Task SetUpConfigAndRunner()
        // {
        //   This method sets up the configuration for running visual tests.
        //   The configuration is shared by all tests in a test suite, so it belongs in a `BeforeAll` method.
        //   If you have more than one test class, then you should abstract this configuration to avoid duplication.
        // }

        private readonly IPage _page;

        [SetUp]
        public async Task Setup()
        {
            RepeatableActions.ActionDriver();

            using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();

            // Browser
            await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = Environment.GetEnvironmentVariable("HEADED") != "1"

                //  Headless = false  // display web pages
                //  Headless = true   // don't display web pages

                // ,Args = clone.Args;
                // ,Channel = clone.Channel;
                // ,ChromiumSandbox = clone.ChromiumSandbox;
                // ,Devtools = clone.Devtools;
                // ,DownloadsPath = clone.DownloadsPath;
                // ,Env = clone.Env;
                // ,ExecutablePath = clone.ExecutablePath;
                // ,FirefoxUserPrefs = clone.FirefoxUserPrefs;
                // ,HandleSIGHUP = clone.HandleSIGHUP;
                // ,HandleSIGINT = clone.HandleSIGINT;
                // ,HandleSIGTERM = clone.HandleSIGTERM;
                // ,Headless = clone.Headless;
                // ,IgnoreAllDefaultArgs = clone.IgnoreAllDefaultArgs;
                // ,IgnoreDefaultArgs = clone.IgnoreDefaultArgs;
                // ,Proxy = clone.Proxy;
                // ,SlowMo = clone.SlowMo;
                // ,Timeout = clone.Timeout;
                // ,TracesDir = clone.TracesDir;
            });

            await RepeatableMethods.LaunchLoginUserBrightHr(Page, urlinfo.TesturlTravelCounsellor, " ", " ");

            // var countacceptcookie = await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "Accept All Cookies").GetResult().CountAsync();
            //var countacceptcookie = await RepeatablePlaywrightMethods.TestElement_GetByText(Page, "Accept All CookiesCookies").GetResult().CountAsync();

            //if (countacceptcookie > 0)
            //{
            //    if (await RepeatablePlaywrightMethods.TestElement_GetByText(Page, "Accept All CookiesCookies").GetResult().IsVisibleAsync())
            //    {
            //        await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, "Accept All Cookies").GetResult().HighlightAsync();
            //        await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, "Accept All Cookies").GetResult().ClickAsync();
            //    }    
            //} 
            await RepeatablePlaywrightMethods.TestButton_GetByRoleCookie(Page, "Accept All CookiesCookies", "Accept All Cookies");

            await Page.Locator(".logo").First.HighlightAsync();  //   TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));
            await Page.Locator(".logo").First.HoverAsync(new() { Timeout = 10_000 });

             await Page.WaitForTimeoutAsync(1000);
        }

        [Test]
        public async Task _0_0_TravelCounsellorLandingCountry()
        {
            await Page.GetByText("Country Select Belgium").HoverAsync(new() { Timeout = 10_000 });

            await Page.GetByRole(AriaRole.Link, new() { Name = "Belgium" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Netherlands" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Ireland" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "South Africa" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "United Arab Emirates" }).HighlightAsync();

            await Page.WaitForTimeoutAsync(1000);
        }

        [Test]
        public async Task _0_1_TravelCounsellorLandingPage()
        {
            await Page.Locator(".logo").First.HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.Locator(".logo").First.HoverAsync();
            await Page.WaitForTimeoutAsync(1000);

            await Page.GetByRole(AriaRole.Link, new() { Name = "Why book with us" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Our difference" }).HighlightAsync(); 
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Book with confidence" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Responsible travel" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);

        }

        [Test]
        public async Task _0_2_TravelCounsellorTopTab()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "How it works" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Inspiration" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Destinations", Exact = true }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Offers" }).HighlightAsync();
            await Page.WaitForTimeoutAsync(1000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Travel advice", Exact = true }).HighlightAsync();

        }

        [Test]
        public async Task _0_3_TravelCounsellorOffice()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "Our Story" }).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Open Preferences" }).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Close Preferences" }).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Open Preferences" }).ClickAsync();
            await Page.GetByLabel("Cookie Categories").ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Close Preferences" }).ClickAsync();

        }

        [Test]
        public async Task _0_4_TravelCounsellorLogin()
        {
            var context = await Browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.travelcounsellors.co.uk/");
            await page.GetByRole(AriaRole.Button, new() { Name = "Accept All Cookies" }).ClickAsync();
            var page1 = await page.RunAndWaitForPopupAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { Name = "Login to myTC" }).ClickAsync();
            });
            await page1.GetByRole(AriaRole.Button, new() { Name = "Accept All Cookies" }).ClickAsync();

            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("icammi@hotmail.co.uk");
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).FillAsync("password");
            await page1.GetByRole(AriaRole.Button, new() { Name = "Sign in" }).ClickAsync();
            await page1.GetByRole(AriaRole.Link, new() { Name = "Make a Guest Payment" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Reference*" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Reference*" }).FillAsync("ref 01");
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Passenger's Surname*" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Passenger's Surname*" }).FillAsync("cance");
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Departure Date*" }).ClickAsync();
            await page1.GetByRole(AriaRole.Textbox, new() { Name = "Departure Date*" }).FillAsync("04/03/2025");
            await page1.GetByRole(AriaRole.Button, new() { Name = "Continue" }).ClickAsync();
            await page1.GetByRole(AriaRole.Button, new() { Name = "Cancel" }).ClickAsync();
            await page1.GetByRole(AriaRole.Button, new() { Name = "Yes" }).ClickAsync();
        }

//[Test]
//public async Task _0_9_TravelCounsellorLandingPage()
//{
/// display links
// await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds)); await Page.WaitForTimeoutAsync(2000);
/// Employees Hub

//await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "See all employees").GetResult().HighlightAsync().WaitAsync(TimeSpan.FromMinutes(waittimevalues.waittimemins));   await Page.WaitForTimeoutAsync(2000);
//await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "See all employees").GetResult().ClickAsync();       await Page.WaitForTimeoutAsync(2000);

//await Page.Locator("#main-content").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();    await Page.WaitForTimeoutAsync(2000);
//await Page.Locator("#main-content").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();        await Page.WaitForTimeoutAsync(2000);

//await Page.GetByRole(AriaRole.Link, new() { Name = "Permissions" }).HighlightAsync();           await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Permissions" }).ClickAsync();               await Page.WaitForTimeoutAsync(2000);

//await Page.GetByRole(AriaRole.Link, new() { Name = "Manage teams PREMIUM" }).HighlightAsync();  await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Manage teams PREMIUM" }).ClickAsync();      await Page.WaitForTimeoutAsync(2000);

//await Page.GetByRole(AriaRole.Link, new() { Name = "Who's in PREMIUM" }).HighlightAsync();      await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Who's in PREMIUM" }).ClickAsync();          await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Img, new() { Name = "covid-pi" }).ScrollIntoViewIfNeededAsync();  await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();             await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                 await Page.WaitForTimeoutAsync(2000);

//await Page.GetByRole(AriaRole.Link, new() { Name = "Recruitment PREMIUM" }).HighlightAsync();   await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Recruitment PREMIUM" }).ClickAsync();       await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Img, new() { Name = "covid-pi" }).ScrollIntoViewIfNeededAsync();  await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HoverAsync();                 await Page.WaitForTimeoutAsync(2000);
//await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                 await Page.WaitForTimeoutAsync(2000);

///// Display Employee details

//await Page.WaitForTimeoutAsync(2000);

//await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^ICIan Campbell$") }).First.HoverAsync();                            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").First.HoverAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));    await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").First.ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));    await Page.WaitForTimeoutAsync(2000);

//await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HoverAsync();                                      await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);


//await Page.WaitForTimeoutAsync(2000);
//await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^FLFirstName01 LastName01JobTitle01$") }).First.HoverAsync();            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").Nth(1).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));   await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").Nth(1).ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));       await Page.WaitForTimeoutAsync(2000);

//await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();                                  await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);


//await Page.WaitForTimeoutAsync(2000);
//await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^FLFirstName02 LastName02JobTitle02$") }).First.HoverAsync();            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").Nth(2).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));   await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("EditButton").Nth(2).ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));       await Page.WaitForTimeoutAsync(2000);

//await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
//await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();                                  await Page.WaitForTimeoutAsync(2000);
//await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);

//await Page.WaitForTimeoutAsync(2000);
//}

[TearDown]
        public async Task TearDown()
        {

            //await RepeatablePlaywrightMethods.TestElement_GetByText(Page, userinfo.Domainuserid).GetResult().ClickAsync(new() { Timeout = 10_000 });
            //await RepeatablePlaywrightMethods.TestElement_GetByText(Page, instructions.SIGNOUT).GetResult().ClickAsync(new() { Timeout = 10_000 });
            //await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, titles.yes).GetResult().ClickAsync(new() { Timeout = 10_000 });

            //await Page.GetByText(userinfo.Domainuserid).WaitForAsync();
            //await Page.GetByText(userinfo.Domainuserid).ClickAsync();
            //await Page.GetByText("Sign out").WaitForAsync();
            //await Page.GetByText("Sign out").ClickAsync();
            //await Page.GetByRole(AriaRole.Button, new() { Name = "Yes" }).WaitForAsync();
            //await Page.GetByRole(AriaRole.Button, new() { Name = "Yes" }).ClickAsync();

            await Page.Locator(".logo").First.HighlightAsync();
            await Page.Locator(".logo").First.HoverAsync();
            await Page.CloseAsync();

            //await RepeatablePlaywrightMethods.TesterSignOut(Page, @"ICEPOR\\t.f.vtos01", instructions.click); 
            //await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, "Yes", instructions.click);

            // Close Eyes to tell the server it should display the results.
            // Eyes.CloseAsync();

            // Close the page.


            // Warning: `eyes_.CloseAsync()` will NOT wait for visual checkpoints to complete.
            // You will need to check the Eyes Test Manager for visual results per checkpoint.
            // Note that "unresolved" and "failed" visual checkpoints will not cause the JUnit test to fail.

            // If you want the JUnit test to wait synchronously for all checkpoints to complete, then use `eyes_.Close()`.
            // If any checkpoints are unresolved or failed, then `eyes_.Close()` will make the JUnit test fail.
        }

        //[OneTimeTearDown]
        //public static void PrintResults()
        //{
        //  //  Close the Playwright instance.
        //      Playwright.Dispose();

        //  //  Close the batch and report visual differences to the console.
        //  //  Note that it forces JUnit to wait synchronously for all visual checkpoints to complete.
        ////    TestResultsSummary allTestResults = Runner.GetAllTestResults();
        ////    TestContext.Out.WriteLine(allTestResults);
        //}
    }
}

