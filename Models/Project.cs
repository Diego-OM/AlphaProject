using System.Collections;

namespace PracticeProject.Models
{
    public class Project
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }

        public Project(Guid projectId, string projectName, string projectDescription)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.ProjectDescription = projectDescription;
        }

        interface IProject
        {
            public IEnumerable<Project> GetProjects();
            public IEnumerable<Project> GetProjectById();

        }
    }
}