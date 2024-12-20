using System;
using System.Collections.Generic;

namespace BookHub.DataAccesLayer.Models;

public partial class Okuyucular
{
    public int OkuyucuId { get; set; }

    public int KullaniciId { get; set; }

    public int HikayeId { get; set; }

    public DateTime BitisTarih { get; set; }

    public DateTime SonNokta { get; set; }
}
