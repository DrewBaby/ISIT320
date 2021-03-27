using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameCharacterAlias")]
    public partial class VideoGameCharacterAlias
    {
        [Key]
        [Column("pkey")]
        public int Pkey { get; set; }
        [Column("characterID")]
        [StringLength(255)]
        public string CharacterId { get; set; }
        [Column("aliasName")]
        [StringLength(255)]
        public string AliasName { get; set; }
    }
}
