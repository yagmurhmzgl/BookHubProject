using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _ServicePartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
