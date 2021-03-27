using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameGenres")]
    public partial class VideoGameGenre
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("genreName")]
        [StringLength(255)]
        public string GenreName { get; set; }
        [Column("slug")]
        [StringLength(255)]
        public string Slug { get; set; }
        [Column("url")]
        [StringLength(255)]
        public string Url { get; set; }
        [Column("checksum")]
        [StringLength(255)]
        public string Checksum { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
