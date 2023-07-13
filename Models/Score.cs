using GolfTrackerBackend.Models;
public class Score
{
    public int Id { get; set; }
    public int RoundId { get; set; }
    public int HoleId { get; set; }
    public int PlayerId { get; set; }
    public int ScoreValue { get; set; }

    public GolfRound? Round { get; set; }
    public Hole? Hole { get; set; }
    public User? Player { get; set; }
}
