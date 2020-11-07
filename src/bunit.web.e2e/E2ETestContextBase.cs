using System;
using System.Collections.Generic;
using System.Text;
using IntelliTect.TestTools.Selenate;

namespace bunit.web.e2e
{
    public class E2ETestContextBase : IDisposable
    {
		private DriverHandler _DriverHandler;

		public DriverHandler Browser
		{
			get
			{
				if (_Driver is null)
				{
					_DriverHandler = new DriverHandler(new WebDriverFactory(BrowserType.ChomeHeadless));
				}
				return _DriverHandler;
			}
		}

		public T PageComponent<T>() where T : PageComponent
		{
			return Activator.CreateInstance<T>();
		}

		public void Dispose()
		{
			_DriverHandler.WrappedDriver.Dispose();
		}
    }
}
