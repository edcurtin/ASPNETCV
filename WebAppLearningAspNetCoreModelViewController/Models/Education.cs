namespace WebAppLearningAspNetCoreModelViewController.Models
{
    public class Education
    {
        public string CourseName { get; set; }
        public string Institution { get; set; }
        public string Dates { get; set; }

        public string Grade { get; set; }

        public List<SemesterModel> Semesters { get; set; } = new List<SemesterModel>();

        public ProjectModel? Project { get; set; }
    }
}
