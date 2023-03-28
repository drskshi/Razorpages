using ISMT_Mart.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ISMT_Mart.Data
{

    public class ISMT_MartDbContext : DbContext
    {
        public ISMT_MartDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee_Mart> Employee { get; set; }


    }
}
