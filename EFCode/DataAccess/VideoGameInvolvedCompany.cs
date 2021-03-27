using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameInvolvedCompanies")]
    public partial class VideoGameInvolvedCompany
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("companyName")]
        [StringLength(255)]
        public string CompanyName { get; set; }
        [Column("parentCompany")]
        [StringLength(255)]
        public string ParentCompany { get; set; }
        [Column("startDate", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("url")]
        [StringLength(255)]
        public string Url { get; set; }
        [Column("country")]
        [StringLength(255)]
        public string Country { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
