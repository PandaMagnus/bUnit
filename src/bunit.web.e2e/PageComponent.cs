using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace bunit.web.e2e
{
	public abstract class RenderComponent
	{
		public RenderComponent(IWebDriver driver)
		{
			_Driver = driver;
		}

		public abstract Uri PageUri { get; set; }
		private IWebDriver _Driver;

		// Eventually convert to Interface
		public Element Find(string cssSelector)
		{
			return new Element(_Driver, cssSelector);
		}
	}
}
