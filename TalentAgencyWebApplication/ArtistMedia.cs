using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class ArtistMedia
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int MediaTypesId { get; set; }
        public string Address { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual MediaType MediaTypes { get; set; }
    }
}
