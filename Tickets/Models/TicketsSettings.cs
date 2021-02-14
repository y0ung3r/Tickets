namespace Tickets.Models
{
    public class TicketsSettings
    {
        public string Header { get; set; }

        public string FacultyTitle { get; set; }

        public string DepartmentTitle { get; set; }

        public string DisciplineTitle { get; set; }

        public string StudyYear { get; set; }

        public string DepartmentChief { get; set; }

        public int QuestionsCount { get; set; }

        public bool CanIncludeTasks { get; set; }

        public int TicketsCount { get; set; }

        public string DestinationFilepath { get; set; }

        public string PathToQuestions { get; set; }

        public string PathToTasks { get; set; }
    }
}
