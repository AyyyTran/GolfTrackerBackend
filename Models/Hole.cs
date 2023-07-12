namespace GolfTrackerBackend.Models
{
    public class Hole
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Par { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}
