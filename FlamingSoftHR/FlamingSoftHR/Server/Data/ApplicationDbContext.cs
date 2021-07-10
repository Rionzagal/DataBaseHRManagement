using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<LogType> LogTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LogTime> LogTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed Departments Table
            builder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Human Resources" });
            builder.Entity<Department>().HasData(
                new Department { Id = 2, Name = "IT"});
            builder.Entity<Department>().HasData(
                new Department { Id = 3, Name = "Development" });
            builder.Entity<Department>().HasData(
                new Department { Id = 4, Name = "Client Relations" });

            //Seed Employee types Table
            builder.Entity<EmployeeType>().HasData(
                new EmployeeType { Id = 1, Description = "Permanent employee"});
            builder.Entity<EmployeeType>().HasData(
                new EmployeeType { Id = 2, Description = "Contractor"});
            builder.Entity<EmployeeType>().HasData(
                new EmployeeType { Id = 3, Description = "Administrator"});

            //Seed Log-in types Table
            builder.Entity<LogType>().HasData(
                new LogType { Id = 1, Description = "Normal work day "});
            builder.Entity<LogType>().HasData(
                new LogType { Id = 2, Description = "Vacation off day"});
            builder.Entity<LogType>().HasData(
                new LogType { Id = 3, Description = "Sick off day"});

            //Seed Employees Table
            builder.Entity<Employee>().HasData(
                new Employee {
                    Id = 100000,
                    UserId = "DMi_00",
                    FirstName = "Miguel",
                    MiddleName = null,
                    LastName = "Diaz",
                    Department = 1,
                    EmployeeType = 3
                });

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 100001,
                    UserId = "PGoRa_01",
                    FirstName = "Gonzalo",
                    MiddleName = "Ramiro",
                    LastName = "Perez",
                    Department = 2,
                    EmployeeType = 1
                });

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 100002,
                    UserId = "AMa_02",
                    FirstName = "María",
                    MiddleName = null,
                    LastName = "Alvarez",
                    Department = 4,
                    EmployeeType = 1
                });
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 100003,
                    UserId = "dJASo_03",
                    FirstName = "Ana",
                    MiddleName = "Sofía",
                    LastName = "de Jesus",
                    Department = 3,
                    EmployeeType = 2
                });

            //Seed Log-ins Table
            builder.Entity<LogTime>().HasData(
                new LogTime
                {
                    Id = 1,
                    DateLogged = new DateTime(2020,12,2, 8, 30, 0),
                    Hours = 8.5,
                    LogType = 1, 
                    LoggedEmployee = 100000,
                });

            builder.Entity<LogTime>().HasData(
                new LogTime
                {
                    Id = 2,
                    DateLogged = new DateTime(2020, 1, 3, 8, 30, 0),
                    Hours = 12.0,
                    LogType = 3,
                    LoggedEmployee = 100002,
                });

            builder.Entity<LogTime>().HasData(
                new LogTime
                {
                    Id = 3,
                    DateLogged = new DateTime(2020, 1, 4, 9, 35, 41),
                    Hours = 5.0,
                    LogType = 3,
                    LoggedEmployee = 100003,
                });
        }
    }
}
