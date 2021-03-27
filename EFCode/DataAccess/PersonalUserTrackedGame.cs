using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("personalUserTrackedGames")]
    public partial class PersonalUserTrackedGame
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

        public virtual VideoGameMain Game { get; set; }
        public virtual UserAccount User { get; set; }
    }
}
