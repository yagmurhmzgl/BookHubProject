using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _SpinnerPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
