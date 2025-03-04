using ClassConfiguration;

namespace playwright_TravelCounsellors_Test.Base
{
	public class CookiesPopup
	{

	}
}
namespace ClassUtilities_AcceptCookie
{
    public class ClassUtilitiesCookies
    {
        public static void NavigatetoURL(IWebDriver _driver)
        {
            _driver.Navigate().GoToUrl(ConfigLibrary.GlobalUrl.fullnameURL);
        }

        public static void Utilities_AcceptCookie(IWebDriver _driver, string cookielink)
        {
            var panelacceptcookie = _driver.FindElements(By.XPath(cookielink));
            if (panelacceptcookie.Count > 0)
            {
                if (panelacceptcookie[0].Displayed)
                {
                  //  ClassUtilitiesHighlight.HighlightElement(_driver, null, "byXpath", cookielink).Click();
                }
            }
        }
    }
}

