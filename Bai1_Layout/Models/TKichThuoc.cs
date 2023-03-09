using System;
using System.Collections.Generic;

namespace Bai1_Layout.Models;

public partial class TKichThuoc
{
    public string MaKichThuoc { get; set; } = null!;

    public string? KichThuoc { get; set; }

    public virtual ICollection<TChiTietSanPham> TChiTietSanPhams { get; } = new List<TChiTietSanPham>();
}
