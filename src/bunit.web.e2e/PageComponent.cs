using System;
using System.Collections.Generic;
using System.Text;

namespace bunit.web.e2e
{
	public abstract class PageComponent
	{
		public abstract Uri PageUri { get; set; }

		public ElementHandler Find(string cssSelector)
		{
			return new ElementHandler(cssSelector);
		}
	}
}
