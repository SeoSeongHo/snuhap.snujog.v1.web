using Microsoft.EntityFrameworkCore;

namespace snuhap.snujog.v1.web.Models.Login
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Infos { get; set; }
    }
}
