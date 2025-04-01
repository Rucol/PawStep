using System;

namespace FitPetAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0;
        public int Coins { get; set; } = 0;
    }
}
