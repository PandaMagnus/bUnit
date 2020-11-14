using bunit.web.e2e;
using System;
using Xunit;

namespace bunit.docs.xunit.e2e.samples
{
    public class ClickTest
    {
        [Fact]
        public void ClickingButtonWorks()
        {
            // Arrange
            using var ctx = new bunit.web.e2e.E2ETestContextBase();
            var cut = ctx.RenderComponent<ClickMe>();
            var buttonElement = cut.Find("button");

            // Act
            buttonElement.Click();

            // Assert
            // ...
        }
    }
}
