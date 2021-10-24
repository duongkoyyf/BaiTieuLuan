using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api
{
    public class NhomHangRepository : INhomHangRepository
    {

        private readonly AppDbContext appDbContext;

        public NhomHangRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public NhomHang GetNhomHang(int nhomHangId)
        {
            return appDbContext.NhomHangs
               .FirstOrDefault(d => d.NhomHangId == nhomHangId);
        }

        public  IEnumerable<NhomHang> GetNhomHangs()
        {
            return appDbContext.NhomHangs;
        }
    }
    
}
