using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameUserContent")]
    public partial class VideoGameUserContent
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("userID")]
        [StringLength(255)]
        public string UserId { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("userRating", TypeName = "decimal(18, 0)")]
        public decimal UserRating { get; set; }
        [Required]
        [Column("userReview")]
        [StringLength(255)]
        public string UserReview { get; set; }

        public virtual VideoGameMain Game { get; set; }
        public virtual UserAccount User { get; set; }
    }
}
