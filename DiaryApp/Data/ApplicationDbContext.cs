using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Welcome to Your Diary",
                    Content = "This is your first diary entry. Feel free to edit or delete it.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Getting Started",
                    Content = "Start writing your thoughts and experiences here. Your diary is a safe space.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Tips for Writing",
                    Content = "Try to write regularly, be honest with yourself, and don't worry about grammar or spelling.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 4,
                    Title = "Reflecting on Your Day",
                    Content = "Take a moment each day to reflect on what happened, how you felt, and what you learned.",
                    Created = DateTime.Now
                }
                );
        }
    }
}
