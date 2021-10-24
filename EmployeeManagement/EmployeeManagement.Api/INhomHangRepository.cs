﻿using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api
{
    public interface INhomHangRepository
    {
        IEnumerable<NhomHang> GetNhomHangs();
        NhomHang GetNhomHang(int nhomHangId);

    }
}
