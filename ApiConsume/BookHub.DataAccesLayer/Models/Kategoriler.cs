using System;
using System.Collections.Generic;

namespace BookHub.DataAccesLayer.Models;

public partial class Kategoriler
{
    public int KategoriId { get; set; }

    public string? Name { get; set; }

    public string? Aciklama { get; set; }
}
