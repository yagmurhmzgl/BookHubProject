using System;
using System.Collections.Generic;

namespace BookHub.WebApi.Models;

public partial class Hikayeler
{
    public int HikayeId { get; set; }

    public int KullaniciId { get; set; }

    public int KategoriId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string HikayeCoverImage { get; set; } = null!;
}
