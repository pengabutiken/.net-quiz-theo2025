using System.Collections.Generic;
using System.Dynamic;

namespace QuizTheo2025.Models
{
    public class Questions
    {
        public string imageUrl { get; set; }
        public List<string> Options { get; set; }
        public int correctIndex { get; set; }
    }
}