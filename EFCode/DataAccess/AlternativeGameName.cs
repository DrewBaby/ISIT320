using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("alternativeGameNames")]
    public partial class AlternativeGameName
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("gameTitle")]
        [StringLength(255)]
        public string GameTitle { get; set; }
        [Column("altName")]
        [StringLength(255)]
        public string AltName { get; set; }
        [Column("checkSum")]
        [StringLength(255)]
        public string CheckSum { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
