using Microsoft.EntityFrameworkCore;

namespace AspNetCore22Test.Data
{
    public class MyDbContext : DbContext
    {
        protected MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}