using System;

namespace FitPetAPI.Models
{
    public class Activity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Type { get; set; } = string.Empty; // "steps", "running", "gym", "cycling"
        public int Value { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
