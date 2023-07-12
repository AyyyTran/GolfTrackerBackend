using GolfTrackerBackend.Models;

    public class GolfRound
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public User? User { get; set; }

        public ICollection<Score> Scores { get; set; }
}
