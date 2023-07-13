using System.Collections.Generic;

namespace GolfTrackerBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        // Collection navigation property
        public ICollection<GolfRound>? GolfRounds { get; set; }
    }
}
