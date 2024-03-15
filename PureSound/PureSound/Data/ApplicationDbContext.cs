using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PureSound.Data.Account;
using PureSound.Data.Configurations;
using PureSound.Data.Entities;

namespace PureSound.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ArtistTrack> ArtistTrack { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>()
                .HasOne(a => a.Genre)
                .WithMany(a => a.Artists)
                .HasForeignKey(a => a.GenreId);

            builder.Entity<Genre>()
                .HasMany(g => g.Users)
                .WithOne(g => g.FavGenre)
                .HasForeignKey(g => g.FavGenreId);
            builder.Entity<Genre>()
                .HasMany(g => g.Tracks)
                .WithOne(g => g.Genre)
                .HasForeignKey(g => g.GenreId);
            builder.Entity<Genre>()
                .HasMany(g => g.Artists)
                .WithOne(g => g.Genre)
                .HasForeignKey(g => g.GenreId);
            builder.Entity<Genre>()
                .HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Rap"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Drill"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Raeggeton"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "House"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "R&B"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Techno"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Phonk"
                },
                new Genre
                {
                    Id = Guid.Parse("48d67181-5732-47a0-892b-6577fc688e00"),
                    Name = "None"
                }
                );

            builder.Entity<Track>()
                .HasOne(s => s.Genre)
                .WithMany(s => s.Tracks)
                .HasForeignKey(s => s.GenreId);

            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.UserId);

            builder.Entity<User>()
                .HasOne(u => u.FavGenre)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.FavGenreId);
            builder.Entity<User>()
                .Property(u => u.ImageUrl)
                .HasDefaultValue("~/img/profilePhoto.png");

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}