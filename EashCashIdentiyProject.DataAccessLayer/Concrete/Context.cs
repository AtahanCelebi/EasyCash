using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EasycashIdentityProject.EntityLayer.Concrete;

namespace EasycashIdentityProject.DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=172.25.75.130; port=3411; database=UserData2; user=lp-admin; pwd=system42135; SslMode=none; pooling=true; default command timeout=100";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 5, 15)), builder =>
        {
            builder.EnableRetryOnFailure();
        });
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
    }
}