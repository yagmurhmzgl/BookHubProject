using System;
using System.Collections.Generic;

namespace BookHub.DataAccesLayer.Models;

public partial class Yorumlar
{
    public int YorumId { get; set; }

    public int KullaniciId { get; set; }

    public int İcerikId { get; set; }

    public DateTime YayınlamaTarih { get; set; }
}
