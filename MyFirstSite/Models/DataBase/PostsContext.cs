using Microsoft.EntityFrameworkCore;

namespace SiteKustiX.Models.DataBase
{
    //сама магия для работы и вывода даных из таблицы
    public sealed class PostsContext : DbContext
    {
        public DbSet<Posts> Postses { get; set; }

        public PostsContext(DbContextOptions<PostsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}