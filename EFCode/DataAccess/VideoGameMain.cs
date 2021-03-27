using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameMain")]
    [Index(nameof(GameId), Name = "UQ__videoGam__DA90B4B3BD95C163", IsUnique = true)]
    public partial class VideoGameMain
    {
        public VideoGameMain()
        {
            AlternativeGameNames = new HashSet<AlternativeGameName>();
            PersonalUserTrackedGames = new HashSet<PersonalUserTrackedGame>();
            VideoGameCharacters = new HashSet<VideoGameCharacter>();
            VideoGameGameModes = new HashSet<VideoGameGameMode>();
            VideoGameGenres = new HashSet<VideoGameGenre>();
            VideoGameInvolvedCompanies = new HashSet<VideoGameInvolvedCompany>();
            VideoGameKeywords = new HashSet<VideoGameKeyword>();
            VideoGameMultiplayerModes = new HashSet<VideoGameMultiplayerMode>();
            VideoGamePlatforms = new HashSet<VideoGamePlatform>();
            VideoGameThemes = new HashSet<VideoGameTheme>();
            VideoGameUserContents = new HashSet<VideoGameUserContent>();
        }

        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Required]
        [Column("gameTitle")]
        [StringLength(255)]
        public string GameTitle { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("category")]
        public int? Category { get; set; }
        [Column("gameStatus")]
        public int? GameStatus { get; set; }
        [Column("ageRatingCategory")]
        public int? AgeRatingCategory { get; set; }
        [Column("ageRatingTitle")]
        public int? AgeRatingTitle { get; set; }
        [Column("ageRatingSynopsis")]
        [StringLength(255)]
        public string AgeRatingSynopsis { get; set; }
        [Column("rating", TypeName = "decimal(18, 0)")]
        public decimal? Rating { get; set; }
        [Column("totalReviews")]
        public int? TotalReviews { get; set; }
        [Column("firstReleaseDate", TypeName = "datetime")]
        public DateTime? FirstReleaseDate { get; set; }
        [Column("versionTitle")]
        [StringLength(255)]
        public string VersionTitle { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<AlternativeGameName> AlternativeGameNames { get; set; }
        public virtual ICollection<PersonalUserTrackedGame> PersonalUserTrackedGames { get; set; }
        public virtual ICollection<VideoGameCharacter> VideoGameCharacters { get; set; }
        public virtual ICollection<VideoGameGameMode> VideoGameGameModes { get; set; }
        public virtual ICollection<VideoGameGenre> VideoGameGenres { get; set; }
        public virtual ICollection<VideoGameInvolvedCompany> VideoGameInvolvedCompanies { get; set; }
        public virtual ICollection<VideoGameKeyword> VideoGameKeywords { get; set; }
        public virtual ICollection<VideoGameMultiplayerMode> VideoGameMultiplayerModes { get; set; }
        public virtual ICollection<VideoGamePlatform> VideoGamePlatforms { get; set; }
        public virtual ICollection<VideoGameTheme> VideoGameThemes { get; set; }
        public virtual ICollection<VideoGameUserContent> VideoGameUserContents { get; set; }
    }
}
