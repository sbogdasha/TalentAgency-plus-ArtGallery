using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class ArtistProject
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int ProjectId { get; set; }
        public string Info { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Project Project { get; set; }
    }
}
