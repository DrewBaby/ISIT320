using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("membershipStatus")]
    [Index(nameof(MembershipStatusId), Name = "UQ__membersh__19137F51F843D279", IsUnique = true)]
    [Index(nameof(Description), Name = "UQ__membersh__489B0D97490255F9", IsUnique = true)]
    public partial class MembershipStatus
    {
        public MembershipStatus()
        {
            UserAccounts = new HashSet<UserAccount>();
        }

        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Column("membershipStatusID")]
        public int MembershipStatusId { get; set; }
        [Required]
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }

        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
