using System;
using System.Collections.Generic;

namespace BANTAPHOA.Data;

public partial class Loaisp
{
    public int Maloaisp { get; set; }

    public string Tenloaisp { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
