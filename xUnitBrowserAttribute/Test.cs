using System.Collections.Generic;
using WatiN.Core;
using Xunit;

namespace xUnitBrowserAttribute
{
    public class Test
    {
        [Fact]
        public void GetData_ReturnsObject()
        {
            BrowserAttribute attribute = new BrowserAttribute("IE");
            IEnumerable<object[]> enumerable = attribute.GetData(null, null);
            foreach (var objectse in enumerable)
            {
                object o = objectse[0];

                Browser browser = o as Browser;

                Assert.NotNull(browser);

            }
        }
    }
}