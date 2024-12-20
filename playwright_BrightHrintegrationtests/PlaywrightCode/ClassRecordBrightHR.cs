using static ClassConfigurationCore.Config;

namespace playwright_newintegrationtests.PlaywrightCode
{
    [Binding]
    public class ClassRecordBrightHR : PageTest
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

            await RepeatableMethods.LaunchLoginUserBrightHr(Page, urlinfo.TesturlbrighthrSandbox, userinfo.Testuserid, userinfo.Testuserpassword);

            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "Sign in with Apple").GetResult().HighlightAsync();
            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "Sign in with Facebook").GetResult().HighlightAsync();
            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "Sign in with Google").GetResult().HighlightAsync();
            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "Sign in with Microsoft").GetResult().HighlightAsync();

            /// Login
            /// 
            await RepeatablePlaywrightMethods.TestTextBox_GetByLabel(Page, BrightHr_obj_pageLogin.text_email).GetResult().FillAsync(userinfo.Testuserid);
            await RepeatablePlaywrightMethods.TestTextBox_GetByLabel(Page, BrightHr_obj_pageLogin.text_password).GetResult().FillAsync(userinfo.Testuserpassword);
            await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, "Login").GetResult().HighlightAsync();
            await RepeatablePlaywrightMethods.TestButton_GetByRole(Page, "Login").GetResult().ClickAsync();
            //   await Page.WaitForTimeoutAsync(2000);
        }

        [Test]
        public async Task _0_1_UserLoginToTheBrightHrlandonsearchpage()
        {
            /// display links
            // await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds)); await Page.WaitForTimeoutAsync(2000);
            /// Employees Hub

            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "See all employees").GetResult().HighlightAsync().WaitAsync(TimeSpan.FromMinutes(waittimevalues.waittimemins));   await Page.WaitForTimeoutAsync(2000);
            await RepeatablePlaywrightMethods.TestLink_GetByRole(Page, "See all employees").GetResult().ClickAsync();       await Page.WaitForTimeoutAsync(2000);

            await Page.Locator("#main-content").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();    await Page.WaitForTimeoutAsync(2000);
            await Page.Locator("#main-content").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();        await Page.WaitForTimeoutAsync(2000);

            await Page.GetByRole(AriaRole.Link, new() { Name = "Permissions" }).HighlightAsync();           await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Permissions" }).ClickAsync();               await Page.WaitForTimeoutAsync(2000);

            await Page.GetByRole(AriaRole.Link, new() { Name = "Manage teams PREMIUM" }).HighlightAsync();  await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Manage teams PREMIUM" }).ClickAsync();      await Page.WaitForTimeoutAsync(2000);

            await Page.GetByRole(AriaRole.Link, new() { Name = "Who's in PREMIUM" }).HighlightAsync();      await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Who's in PREMIUM" }).ClickAsync();          await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Img, new() { Name = "covid-pi" }).ScrollIntoViewIfNeededAsync();  await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();             await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                 await Page.WaitForTimeoutAsync(2000);
            
            await Page.GetByRole(AriaRole.Link, new() { Name = "Recruitment PREMIUM" }).HighlightAsync();   await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Recruitment PREMIUM" }).ClickAsync();       await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Img, new() { Name = "covid-pi" }).ScrollIntoViewIfNeededAsync();  await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).HoverAsync();                 await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                 await Page.WaitForTimeoutAsync(2000);

            /// Display Employee details

            await Page.WaitForTimeoutAsync(2000);

            await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^ICIan Campbell$") }).First.HoverAsync();                            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").First.HoverAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));    await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").First.ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));    await Page.WaitForTimeoutAsync(2000);

            await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HoverAsync();                                      await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);


            await Page.WaitForTimeoutAsync(2000);
            await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^FLFirstName01 LastName01JobTitle01$") }).First.HoverAsync();            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").Nth(1).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));   await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").Nth(1).ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));       await Page.WaitForTimeoutAsync(2000);

            await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();                                  await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);


            await Page.WaitForTimeoutAsync(2000);
            await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^FLFirstName02 LastName02JobTitle02$") }).First.HoverAsync();            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").Nth(2).HighlightAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));   await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("EditButton").Nth(2).ClickAsync().WaitAsync(TimeSpan.FromMilliseconds(waittimevalues.waittimemilliliseconds));       await Page.WaitForTimeoutAsync(2000);

            await Page.GetByLabel("First name").HighlightAsync();               await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Last name").HighlightAsync();                await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Email Address").HighlightAsync();            await Page.WaitForTimeoutAsync(2000);
            await Page.GetByLabel("Phone Number(Optional)").HighlightAsync();   await Page.WaitForTimeoutAsync(2000);

            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).HighlightAsync();                                  await Page.WaitForTimeoutAsync(2000);
            await Page.GetByTestId("sideBar").GetByRole(AriaRole.Link, new() { Name = "Employees" }).ClickAsync();                                      await Page.WaitForTimeoutAsync(2000);

            await Page.WaitForTimeoutAsync(2000);
        }

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

            await Page.GetByRole(AriaRole.Link, new() { Name = "Logout" }).HighlightAsync(); await Page.WaitForTimeoutAsync(2000);
            await Page.GetByRole(AriaRole.Link, new() { Name = "Logout" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });

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

