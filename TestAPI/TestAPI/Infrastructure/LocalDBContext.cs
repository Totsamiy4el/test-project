using Microsoft.EntityFrameworkCore;

namespace TestAPI.Infrastructure;

public class LocalDBContext : DbContext
{

    public LocalDBContext(DbContextOptions<LocalDBContext> options)
        : base(options)
    {
    }
}


