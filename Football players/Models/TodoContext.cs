using Microsoft.EntityFrameworkCore;

namespace Football_players.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options){
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
