using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameThemes")]
    public partial class VideoGameTheme
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("themeName")]
        [StringLength(255)]
        public string ThemeName { get; set; }
        [Column("themeSlug")]
        [StringLength(255)]
        public string ThemeSlug { get; set; }
        [Column("url")]
        [StringLength(255)]
        public string Url { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
