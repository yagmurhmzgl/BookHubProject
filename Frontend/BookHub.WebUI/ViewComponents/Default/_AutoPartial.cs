using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _AutoPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			{
				return View();
			}
		}
	}
}
