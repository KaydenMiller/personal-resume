namespace DataAccessLayer.Models
{
    public class SkillModel
    {
        public int Id { get; set; }
        public int SkillCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float PersonalStarRating { get; set; }
        public string Tooltip { get; set; }
    }
}