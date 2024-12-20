using System;
using System.Collections.Generic;

namespace BookHub.DataAccesLayer.Models;

public partial class Kullanicilar
{
    public int KullaniciId { get; set; }

    public string Name { get; set; } = null!;

    public string Eposta { get; set; } = null!;

    public string Sifre { get; set; } = null!;

    public string ProfilResmi { get; set; } = null!;

    public string Biyografi { get; set; } = null!;
}
