using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldExample.Models
{
    public partial class VAssocSeqLineItem
    {
        public string OrderNumber { get; set; }
        public byte LineNumber { get; set; }
        public string Model { get; set; }
    }
}
