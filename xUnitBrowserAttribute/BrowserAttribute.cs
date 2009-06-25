using System;
using System.Collections.Generic;
using System.Reflection;
using WatiN.Core;
using Xunit.Extensions;

namespace xUnitBrowserAttribute
{
    public class BrowserAttribute : DataAttribute
    {
        public string Browser { get; set; }
        public BrowserAttribute(string browser)
        {
            Browser = browser;
        }

        public override IEnumerable<object[]> GetData(MethodInfo methodUnderTest, Type[] parameterTypes)
        {
            Type type = Assembly.GetAssembly(typeof(Browser)).GetType("WatiN.Core." + Browser);
            return new[] { new[] {Activator.CreateInstance(type) }};
        }
    }
}