using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("userAccount")]
    [Index(nameof(UserName), Name = "UQ__userAcco__66DCF95C492B076C", IsUnique = true)]
    [Index(nameof(Email), Name = "UQ__userAcco__AB6E6164FF73E496", IsUnique = true)]
    [Index(nameof(UserId), Name = "UQ__userAcco__CB9A1CDE9B8F1BD3", IsUnique = true)]
    public partial class UserAccount
    {
        public UserAccount()
        {
            PersonalUserTrackedGames = new HashSet<PersonalUserTrackedGame>();
            UserGamerTags = new HashSet<UserGamerTag>();
            VideoGameUserContents = new HashSet<VideoGameUserContent>();
        }

        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("userID")]
        [StringLength(255)]
        public string UserId { get; set; }
        [Required]
        [Column("userName")]
        [StringLength(255)]
        public string UserName { get; set; }
        [Column("membershipStatusID")]
        public int MembershipStatusId { get; set; }
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("addressStreet")]
        [StringLength(255)]
        public string AddressStreet { get; set; }
        [Column("addressStreet2")]
        [StringLength(255)]
        public string AddressStreet2 { get; set; }
        [Column("addressCity")]
        [StringLength(255)]
        public string AddressCity { get; set; }
        [Column("addressState")]
        [StringLength(255)]
        public string AddressState { get; set; }
        [Column("addressZipCode")]
        [StringLength(255)]
        public string AddressZipCode { get; set; }
        [Required]
        [Column("created_at")]
        public byte[] CreatedAt { get; set; }

        public virtual MembershipStatus MembershipStatus { get; set; }
        public virtual ICollection<PersonalUserTrackedGame> PersonalUserTrackedGames { get; set; }
        public virtual ICollection<UserGamerTag> UserGamerTags { get; set; }
        public virtual ICollection<VideoGameUserContent> VideoGameUserContents { get; set; }
    }
}
