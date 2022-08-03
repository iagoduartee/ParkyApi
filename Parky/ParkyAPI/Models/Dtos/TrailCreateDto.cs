using ParkyAPI.Models.Enum;

namespace ParkyAPI.Models.Dtos
{
    public class TrailCreateDto
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public DifficultyType Difficulty { get; set; }
        public int NationalParkId { get; set; }
    }
}
