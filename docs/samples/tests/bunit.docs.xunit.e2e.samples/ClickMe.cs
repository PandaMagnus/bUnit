using System;
using bunit.web.e2e;
using OpenQA.Selenium;

namespace bunit.docs.xunit.e2e.samples
{
    public class ClickMe : RenderComponent
    {
        public ClickMe(IWebDriver driver) : base(driver)
        {
            
        }

        public override Uri PageUri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
