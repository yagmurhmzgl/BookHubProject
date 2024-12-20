using System.ComponentModel.DataAnnotations;

namespace BookHub.WebUI.Dtos.CategoryDto
{
	public class ResultCategoryDto
	{
		[Key]
		public int KategoriId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

	}
}
