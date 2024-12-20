using System;
using System.Collections.Generic;

namespace BookHub.WebApi.Models;

public partial class Begeniler
{
    public int BegeniId { get; set; }

    public int HikayeId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime BegeniTarih { get; set; }
}
