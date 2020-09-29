using SamuraiApp.Domain.DataModels;

namespace SamuraiApp.Domain.Models
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }
        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
