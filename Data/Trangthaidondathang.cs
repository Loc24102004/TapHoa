using System;
using System.Collections.Generic;

namespace BANTAPHOA.Data;

public partial class Trangthaidondathang
{
    public int Mattddh { get; set; }

    public string Tenttddh { get; set; } = null!;

    public virtual ICollection<Dondathang> Dondathangs { get; set; } = new List<Dondathang>();
}
