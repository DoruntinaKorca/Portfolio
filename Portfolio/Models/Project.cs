using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string RepositoryLink { get; set; }

        public string repoName { get; set; }


        public string Description { get; set; }
    }
}
