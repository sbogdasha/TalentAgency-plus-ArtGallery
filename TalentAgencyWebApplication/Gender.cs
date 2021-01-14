using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Gender
    {
        public Gender()
        {
            Artists = new HashSet<Artist>();
        }

        public int Id { get; set; }
        public string Gender1 { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
