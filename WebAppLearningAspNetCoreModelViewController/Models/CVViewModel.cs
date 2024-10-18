using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebAppLearningAspNetCoreModelViewController.Models
{
    public class CVViewModel
    {
        public string Name { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }

        public string LinkedIn { get; set; }
        public string Phone { get; set; }

        public string WorkingModel { get; set; }
        public List<Experience> WorkExperiences { get; set; }
        public List<Education> Educations { get; set; }
    }
}
