using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace bunit.web.e2e
{
	public class Element
	{
		public Element(IWebDriver driver, string cssSelector)
		{
			_Driver = driver;
			_Selector = cssSelector;
		}

		private string _Selector;
		private IWebDriver _Driver;

		public void Click()
		{
			var wait = new WebDriverWait(new SystemClock(), _Driver, TimeSpan.FromSeconds(1), TimeSpan.FromMilliseconds(100));
			wait.IgnoreExceptionTypes(
				typeof(StaleElementReferenceException),
				typeof(ElementClickInterceptedException),
				typeof(InvalidElementStateException),
				typeof(ElementNotVisibleException));

			wait.Until(d =>
			{
				IWebElement elem = d.FindElement(By.CssSelector(_Selector));
				elem.Click();
				return true;
			});
		}
	}
}
