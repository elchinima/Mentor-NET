namespace Mentor.NET.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Decription { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
}