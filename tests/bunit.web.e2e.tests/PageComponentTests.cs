using Moq;
using OpenQA.Selenium;
using Xunit;

namespace bunit.web.e2e.tests
{
	public class PageComponentTests
    {
		[Fact]
		public void ExampleSeleniumMock()
		{
			var mockElement = new Mock<IWebElement>();
			mockElement.SetupProperty(e => e.Displayed, true);

			var mockDriver = new Mock<IWebDriver>();
			mockDriver.SetupGet(t => t.Title).Returns("Test Title");
			mockDriver.Setup(f => f.FindElement(By.CssSelector("someCssSelector")))
				.Returns(mockElement.Object);

			IWebDriver driverTest = mockDriver.Object;
			Assert.NotNull(driverTest);
			Assert.NotNull(driverTest.FindElement(By.CssSelector("someCssSelector")));
			Assert.Null(driverTest.FindElement(By.CssSelector("someOtherCssSelector")));
		}
    }
}
