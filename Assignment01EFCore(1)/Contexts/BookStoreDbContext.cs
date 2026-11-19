using Assignment01EFCore_1_.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment01EFCore_1_.Contexts;
internal class BookStoreDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionString
        optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    // DbSets Represents a table at DB 
    // Without it the migration two overrided methods will still empty
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    /*
    - I installed Microsoft.EntityFrameworkCore.Tools 
    - In Package Manager Console :
    --> Add-Migration -Name "InitialCreate" 
    [Folder Called "Migrations" will be created which has the InitialCreate Migration and the snapshot which contains the current state of the last migration created]
    --> Update-Datebase 
    [DB is created] -- I checked it :)
    */
}