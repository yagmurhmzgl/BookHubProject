using System;
using System.Collections.Generic;

namespace BookHub.WebApi.Models;

public partial class Kategoriler
{
    public int KategoriId { get; set; }

    public string KategoriTur { get; set; } = null!;
}
