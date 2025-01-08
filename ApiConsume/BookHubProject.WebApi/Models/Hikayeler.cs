using System;
using System.Collections.Generic;

namespace BookHub.WebApi.Models;

public partial class Hikayeler
{
    public int HikayeId { get; set; }

    public int? YazarId { get; set; }

    public int KullaniciId { get; set; }

    public int KategoriId { get; set; }

    public string Name { get; set; } = null!;

    public string Decription { get; set; } = null!;

    public string HikayeCoverImage { get; set; } = null!;
}
