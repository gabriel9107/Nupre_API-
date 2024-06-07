using Microsoft.EntityFrameworkCore;

namespace Nupre_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ): base(options)
        {
                
        }
    }
}
