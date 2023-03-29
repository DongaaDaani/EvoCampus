using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class CasinoContext : DbContext
    {
        public CasinoContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGameSession>()
                        .HasKey(ug => new { ug.UserId, ug.GameSessionId });

            modelBuilder.Entity<UserGameSession>()
                        .HasOne(ug => ug.User)
                        .WithMany(u => u.UserGameSessions)
                        .HasForeignKey(ug => ug.UserId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserGameSession>()
                        .HasOne(ug => ug.GameSession)
                        .WithMany(c => c.UserGameSessions)
                        .HasForeignKey(ug => ug.GameSessionId)
                        .OnDelete(DeleteBehavior.NoAction);
                        
            modelBuilder.Entity<UserRound>()
                        .HasOne(ug => ug.User)
                        .WithMany(u => u.UserRounds)
                        .HasForeignKey(ug => ug.UserId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserRound>()
                        .HasOne(ug => ug.Round)
                        .WithMany(c => c.UserRounds)
                        .HasForeignKey(ug => ug.RoundId)
                        .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<UserGameSession> UserGameSessions { get; set; }
        public DbSet<UserRound> UserRounds { get; set; }
    }
}
