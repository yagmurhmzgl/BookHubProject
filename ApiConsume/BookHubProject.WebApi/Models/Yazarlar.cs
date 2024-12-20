using System;
using System.Collections.Generic;

namespace BookHub.WebApi.Models;

public partial class Yazarlar
{
    public int YazarId { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSoyadi { get; set; }
}
