using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("userGamerTags")]
    public partial class UserGamerTag
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("userID")]
        [StringLength(255)]
        public string UserId { get; set; }
        [Required]
        [Column("gamerTag")]
        [StringLength(255)]
        public string GamerTag { get; set; }

        public virtual UserAccount User { get; set; }
    }
}
