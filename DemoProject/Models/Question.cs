using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string Hint { get; set; } = string.Empty;
    }

}
