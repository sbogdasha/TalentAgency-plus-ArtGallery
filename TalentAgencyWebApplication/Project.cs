using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Project
    {
        public Project()
        {
            ArtistProjects = new HashSet<ArtistProject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int ActivityId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual ICollection<ArtistProject> ArtistProjects { get; set; }
    }
}
