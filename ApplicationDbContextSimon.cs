using Microsoft.EntityFrameworkCore;

namespace Nupre_API
{
    public class ApplicationDbContextSimon : DbContext
    {
        public ApplicationDbContextSimon(DbContextOptions options) : base(options)
        {

        }


    }
}
