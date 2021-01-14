using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Activity
    {
        public Activity()
        {
            ArtistActivities = new HashSet<ArtistActivity>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Activity1 { get; set; }

        public virtual ICollection<ArtistActivity> ArtistActivities { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
