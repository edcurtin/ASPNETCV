namespace WebAppLearningAspNetCoreModelViewController.Models
{
    public class Experience
    {
        public string Role { get; set; }
        public string Company { get; set; }
        public string Dates { get; set; }
        public string Description { get; set; }

        public bool? IsCurrent { get; set; }

        public List<Tech> TechUsed { get; set; }
    }
}
