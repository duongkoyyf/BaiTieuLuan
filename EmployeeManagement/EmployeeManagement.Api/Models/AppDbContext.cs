using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<NhomHang> NhomHangs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                Ten = "Nike Air Zoom Alphafly NEXT%",
                NhomHangId = 1,
                SoLuongMau = 1,
                Gia = 8059000,

                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/air-zoom-alphafly-next-road-racing-shoes-13jzhr.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                Ten = "Nike Air Zoom Alphafly NEXT%",
                NhomHangId = 2,
                SoLuongMau = 1,
                Gia = 8059000,

                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/air-zoom-alphafly-next-racing-shoe-Wd4lk6.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                Ten = "Nike ZoomX Vaporfly Next% 2",
                NhomHangId = 1,
                SoLuongMau = 1,
                Gia = 6609000,

                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/zoomx-vaporfly-next-2-road-racing-shoes-D4ntS0.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                Ten = "Nike ZoomX Vaporfly Next% 2",
                NhomHangId = 2,
                SoLuongMau = 1,
                Gia = 6609000,

                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/zoomx-vaporfly-next-2-road-racing-shoes-fG92S8.jpg"
            });
            //Seed NhomHnag Table
            modelBuilder.Entity<NhomHang>().HasData(
                new NhomHang { NhomHangId = 1, NhomHangName = "Men's Road Racing Shoes" });
            modelBuilder.Entity<NhomHang>().HasData(
                new NhomHang { NhomHangId = 2, NhomHangName = "Women's Racing Shoe" });
           

        }
    }
}
