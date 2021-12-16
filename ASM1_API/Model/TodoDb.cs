using Microsoft.EntityFrameworkCore;

namespace ASM1_API.Model
{
    
        public class TodoDb : DbContext
        {
            public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

            public DbSet<Todo> Todos => Set<Todo>();
        }
    
}
