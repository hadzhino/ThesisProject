using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PureSound.Data.Account;
using PureSound.Data.Entities;

namespace PureSound.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(a => a.Albums)
                .HasForeignKey(a => a.ArtistId);
            builder.Entity<Album>()
                .HasMany(a => a.Songs)
                .WithOne(a => a.Album)
                .HasForeignKey(a => a.AlbumId);

            builder.Entity<Artist>()
                .HasMany(a => a.Songs)
                .WithMany(a => a.Artists);
            builder.Entity<Artist>()
                .HasMany(a => a.Albums)
                .WithOne(a => a.Artist)
                .HasForeignKey(a => a.ArtistId);
            builder.Entity<Artist>()
                .HasOne(a => a.MainGenre)
                .WithMany(a => a.Artists)
                .HasForeignKey(a => a.GenreId);

            builder.Entity<Genre>()
                .HasMany(g => g.Users)
                .WithOne(g => g.FavGenre)
                .HasForeignKey(g => g.GenreId);
            builder.Entity<Genre>()
                .HasMany(g => g.Songs)
                .WithOne(g => g.Genre)
                .HasForeignKey(g => g.GenreId);
            builder.Entity<Genre>()
                .HasMany(g => g.Artists)
                .WithOne(g => g.MainGenre)
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
                }
                );

            builder.Entity<Song>()
                .HasMany(s => s.Artists)
                .WithMany(s => s.Songs);
            builder.Entity<Song>()
                .HasOne(s => s.Genre)
                .WithMany(s => s.Songs)
                .HasForeignKey(s => s.GenreId);
            builder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(s => s.Songs)
                .HasForeignKey(s => s.AlbumId);

            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.UserId);


            base.OnModelCreating(builder);
        }
    }
}