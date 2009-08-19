using WatiN.Core;
using Xunit;
using Xunit.Extensions;

namespace xUnitBrowserAttribute
{
    public class Example
    {
        [Theory]
        [Browser("IE")]
        [Browser("FireFox")]
        //[Browser("Chrome")]
        public void Should_Click_Search_On_Google_And_Return_Results_For_AspNet(Browser browser)
        {
            browser.GoTo("http://www.google.co.uk");
            browser.TextField(Find.ByName("q")).Value = "asp.net";
            browser.Button(Find.ByName("btnG")).Click();

            string testString = "The Official Microsoft ASP.NET Site";
            browser.WaitUntilContainsText(testString);
            Assert.True(browser.ContainsText(testString));
            browser.Dispose();
        }
    }
}
