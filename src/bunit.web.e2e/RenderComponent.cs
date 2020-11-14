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
		private readonly IWebDriver _Driver;

		public Element Find(string cssSelector)
		{
			return new Element(_Driver, cssSelector);
		}
	}
}
