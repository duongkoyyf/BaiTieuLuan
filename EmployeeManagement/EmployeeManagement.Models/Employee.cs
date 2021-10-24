using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Ten { get; set; }
        public int NhomHangId { get; set; }
        public int SoLuongMau { get; set; }
        public float Gia { get; set; }
        public string PhotoPath { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public NhomHang NhomHang { get; set; }


    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
