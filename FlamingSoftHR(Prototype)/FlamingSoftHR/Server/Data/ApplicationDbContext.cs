using FlamingSoftHR.Shared.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FlamingSoftHR.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Department> Department { get; set; } //Including Department table model to DbContext
        public DbSet<EmployeeType> EmployeeType { get; set; } //Including Employee Type table model to DbContext
        public DbSet<LogType> LogType { get; set; } //Including Log-in Type table model to DbContext
        public DbSet<Employees> Employees { get; set; } //Including Employees table model to DbContext
        public DbSet<LogTime> LogTime { get; set; } //Including Log-in time table model to DbContext

    }
}
