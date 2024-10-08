using Database_Example.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using System.Threading;

namespace Database_Example.Database
{
        public class DatabaseContext : DbContext
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kaskadowe usuwanie FlashCard -> Words
            //modelBuilder.Entity<Words>()
            //    .HasOne(w => w.FlashCards)
            //    .WithMany(f => f.Words)
            //    .HasForeignKey(w => w.FlashCardId)
            //    .OnDelete(DeleteBehavior.Cascade);  // Usunięcie fiszki spowoduje usunięcie powiązanych słów

            // Usunięcie słowa nie usunie fiszki (restrict)
            modelBuilder.Entity<FlashCards>()
                .HasMany(f => f.Words)
                .WithOne(w => w.FlashCards)
                .HasForeignKey(w => w.FlashCardId)
                .OnDelete(DeleteBehavior.NoAction);  // Usunięcie słowa nie usunie fiszki

            modelBuilder.Entity<Users>()
                .HasMany(u => u.Exams)
                .WithOne(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);
                
        }
        DbSet<Users> User { get; set; }
        DbSet<FlashCards> FlashCards { get; set; }
        DbSet<Words> Word { get; set; }
        DbSet<FavouriteWords> FavouriteUsersWord { get; set; }
        DbSet<Exam> Exam { get; set; }
    }
}
