using System.Collections;
using PracticeProject.Interfaces;

namespace PracticeProject.Models
{
    public class Project: IProject
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

        public IEnumerable<Project> GetProjects(){
            Stack<int> stackOfInts = new Stack<int>();
            return (IEnumerable<Project>) stackOfInts;
        }

         public IEnumerable<Project> GetProjectById(){
            Stack<int> stackOfInts = new Stack<int>();
            return (IEnumerable<Project>) stackOfInts;
        }
    }
}