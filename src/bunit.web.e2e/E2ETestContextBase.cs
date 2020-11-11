using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace bunit.web.e2e
{
    public class E2ETestContextBase : IDisposable
    {
		// Add default services here.
		// Need one for each driver we want to support.
		// May need to write utility to automagically fetch the right driver version to avoid having to manage that directly, if that approach isn't too infeasible.

		private IWebDriver? _Driver;

		public IWebDriver Driver
		{
			get
			{
				if (_Driver is null)
				{
					_Driver = new ChromeDriver();
				}
				return _Driver;
			}
		}

		public T RenderComponent<T>() where T : RenderComponent
		{
			T component = Activator.CreateInstance<T>();
			Driver.Navigate().GoToUrl(component.PageUri);
			return component;
		}

		public void Dispose()
		{
			Driver?.Dispose();
		}
    }
}
