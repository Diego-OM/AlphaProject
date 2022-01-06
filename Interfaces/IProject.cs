using PracticeProject.Models;

namespace PracticeProject.Interfaces
{
    public interface IProject
    {
        public IEnumerable<Project> GetProjects();
        public IEnumerable<Project> GetProjectById();

    }
}