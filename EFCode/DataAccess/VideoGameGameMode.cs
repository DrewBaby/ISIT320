using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameGameModes")]
    public partial class VideoGameGameMode
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("gameModeName")]
        [StringLength(255)]
        public string GameModeName { get; set; }
        [Column("gameModeURL")]
        [StringLength(255)]
        public string GameModeUrl { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        [Column("slug")]
        [StringLength(255)]
        public string Slug { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
