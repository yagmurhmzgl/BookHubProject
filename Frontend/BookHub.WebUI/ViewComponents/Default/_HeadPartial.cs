﻿using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _HeadPartial : ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

