using System.Collections.Generic;

namespace _net_quiz_theo2025.Models
{
    public class Question
    {
        public string ImageUrl { get; set; }
        public List<string> Options { get; set; }
        public int CorrectIndex { get; set; }
    }
}
