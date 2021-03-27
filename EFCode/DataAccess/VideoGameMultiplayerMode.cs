using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCode.DataAccess
{
    [Table("videoGameMultiplayerMode")]
    public partial class VideoGameMultiplayerMode
    {
        [Key]
        [Column("pKey")]
        public int PKey { get; set; }
        [Required]
        [Column("gameID")]
        [StringLength(255)]
        public string GameId { get; set; }
        [Column("campaignCoop")]
        public bool? CampaignCoop { get; set; }
        [Column("dropIn")]
        public bool? DropIn { get; set; }
        [Column("lanCoop")]
        public bool? LanCoop { get; set; }
        [Column("offlineCoop")]
        public bool? OfflineCoop { get; set; }
        [Column("offlineCoopMax")]
        public int? OfflineCoopMax { get; set; }
        [Column("onlineCoop")]
        public bool? OnlineCoop { get; set; }
        [Column("onlineCoopMax")]
        public int? OnlineCoopMax { get; set; }
        [Column("onlineMax")]
        public int? OnlineMax { get; set; }
        [Column("splitscreen")]
        public bool? Splitscreen { get; set; }
        [Column("splitscreenOnline")]
        public bool? SplitscreenOnline { get; set; }

        public virtual VideoGameMain Game { get; set; }
    }
}
