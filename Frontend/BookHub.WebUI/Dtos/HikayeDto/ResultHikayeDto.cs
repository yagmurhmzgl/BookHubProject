namespace BookHub.WebUI.Dtos.ResultDto
{
	public class ResultHikayeDto
	{
		public int HikayeId { get; set; }
		public int KullaniciId { get; set; }
		public int KategoriId { get; set; }
		public int IcerikId { get; set; }
		public string? Name { get; set; }
		public string? Decription { get; set; }
		public string? HikayeCoverImage { get; set; }

	}
}
