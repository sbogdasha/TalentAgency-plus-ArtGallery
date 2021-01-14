using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Portfolio
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public DateTime Date { get; set; }
        public byte[] Photo { get; set; }
        public string Info { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
