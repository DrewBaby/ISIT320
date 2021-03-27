using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCode.DataAccess
{
    public partial class DbContext : DbContext
    {
        public DbContext()
        {
        }

        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlternativeGameName> AlternativeGameNames { get; set; }
        public virtual DbSet<MembershipStatus> MembershipStatuses { get; set; }
        public virtual DbSet<PersonalUserTrackedGame> PersonalUserTrackedGames { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserGamerTag> UserGamerTags { get; set; }
        public virtual DbSet<VideoGameCharacter> VideoGameCharacters { get; set; }
        public virtual DbSet<VideoGameCharacterAlias> VideoGameCharacterAliases { get; set; }
        public virtual DbSet<VideoGameGameMode> VideoGameGameModes { get; set; }
        public virtual DbSet<VideoGameGenre> VideoGameGenres { get; set; }
        public virtual DbSet<VideoGameInvolvedCompany> VideoGameInvolvedCompanies { get; set; }
        public virtual DbSet<VideoGameKeyword> VideoGameKeywords { get; set; }
        public virtual DbSet<VideoGameMain> VideoGameMains { get; set; }
        public virtual DbSet<VideoGameMultiplayerMode> VideoGameMultiplayerModes { get; set; }
        public virtual DbSet<VideoGamePlatform> VideoGamePlatforms { get; set; }
        public virtual DbSet<VideoGameTheme> VideoGameThemes { get; set; }
        public virtual DbSet<VideoGameUserContent> VideoGameUserContents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=GameClubDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AlternativeGameName>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__alternat__4866A5D7332AFD9C");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.AlternativeGameNames)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__alternati__gameI__4AB81AF0");
            });

            modelBuilder.Entity<MembershipStatus>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__membersh__4866A5D7793979D3");
            });

            modelBuilder.Entity<PersonalUserTrackedGame>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__personal__4866A5D7D86F2E6B");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.PersonalUserTrackedGames)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__personalU__gameI__49C3F6B7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonalUserTrackedGames)
                    .HasPrincipalKey(p => p.UserId)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__personalU__userI__48CFD27E");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__userAcco__4866A5D7D0423552");

                entity.Property(e => e.CreatedAt)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MembershipStatus)
                    .WithMany(p => p.UserAccounts)
                    .HasPrincipalKey(p => p.MembershipStatusId)
                    .HasForeignKey(d => d.MembershipStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userAccou__membe__46E78A0C");
            });

            modelBuilder.Entity<UserGamerTag>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__userGame__4866A5D73F759E7F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGamerTags)
                    .HasPrincipalKey(p => p.UserId)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userGamer__userI__47DBAE45");
            });

            modelBuilder.Entity<VideoGameCharacter>(entity =>
            {
                entity.HasKey(e => new { e.PKey, e.CharacterId })
                    .HasName("PK__videoGam__A2B9344E1AE22C4E");

                entity.Property(e => e.PKey).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameCharacters)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__4E88ABD4");
            });

            modelBuilder.Entity<VideoGameCharacterAlias>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("PK__videoGam__40A62DB9FCFD6C6E");
            });

            modelBuilder.Entity<VideoGameGameMode>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D743794526");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameGameModes)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__4BAC3F29");
            });

            modelBuilder.Entity<VideoGameGenre>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D77B5F7403");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameGenres)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__5165187F");
            });

            modelBuilder.Entity<VideoGameInvolvedCompany>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D793F1AB89");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameInvolvedCompanies)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__5535A963");
            });

            modelBuilder.Entity<VideoGameKeyword>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D72105B259");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameKeywords)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__5441852A");
            });

            modelBuilder.Entity<VideoGameMain>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D71955ACA3");
            });

            modelBuilder.Entity<VideoGameMultiplayerMode>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D72904CA6A");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameMultiplayerModes)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__52593CB8");
            });

            modelBuilder.Entity<VideoGamePlatform>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D7D6ED6ADE");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGamePlatforms)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__5070F446");
            });

            modelBuilder.Entity<VideoGameTheme>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D7F8F1A212");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameThemes)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__534D60F1");
            });

            modelBuilder.Entity<VideoGameUserContent>(entity =>
            {
                entity.HasKey(e => e.PKey)
                    .HasName("PK__videoGam__4866A5D7B761DCE5");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.VideoGameUserContents)
                    .HasPrincipalKey(p => p.GameId)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__gameI__4D94879B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoGameUserContents)
                    .HasPrincipalKey(p => p.UserId)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__videoGame__userI__4CA06362");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
