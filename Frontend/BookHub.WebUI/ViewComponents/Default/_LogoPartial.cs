using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _LogoPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
