﻿using System;
using System.Collections.Generic;

namespace Bai1_Layout.Models;

public partial class TQuocGia
{
    public string MaNuoc { get; set; } = null!;

    public string? TenNuoc { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; } = new List<TDanhMucSp>();
}
