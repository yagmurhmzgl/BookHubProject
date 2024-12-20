using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _SectionPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{ 
			return View(); 
		}	
	}
}
