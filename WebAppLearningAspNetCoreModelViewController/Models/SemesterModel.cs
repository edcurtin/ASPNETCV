namespace WebAppLearningAspNetCoreModelViewController.Models
{
    public class SemesterModel
    {
        public string Name { get; set; }

        public List<ResultModel> Results { get; set; } = new List<ResultModel>();
    }
}
