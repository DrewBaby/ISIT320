using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameCharacters")]
    [Index(nameof(CharacterId), Name = "videoGameCharacters_CharacterID")]
    public partial class VideoGameCharacter
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Key]
        [Column("characterID")]
        [StringLength(255)]
        public string CharacterId { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("species")]
        public int? Species { get; set; }
        [Column("countryName")]
        [StringLength(255)]
        public string CountryName { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("gender")]
        public int? Gender { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
