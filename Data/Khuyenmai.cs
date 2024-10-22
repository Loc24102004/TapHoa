using System;
using System.Collections.Generic;

namespace BANTAPHOA.Data;

public partial class Khuyenmai
{
    public int Makm { get; set; }

    public double Phantramgiam { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
