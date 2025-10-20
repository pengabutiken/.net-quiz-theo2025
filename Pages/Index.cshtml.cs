using Microsoft.AspNetCore.Mvc.RazorPages;
using _net_quiz_theo2025.Models;
using System.Collections.Generic;

namespace _net_quiz_theo2025.Pages
{
    public class IndexModel : PageModel
    {
        public List<Question> Questions { get; set; }

        public void OnGet()
        {
            Questions = new List<Question>
            {
                new Question
                {
                    ImageUrl = "/images/nosferatu.jpg",
                    Options = new List<string> { "Nosferatu The Vampire", "Petra Von Kant", "Tjena", "The Prestige" },
                    CorrectIndex = 0
                }

            };
        }
    }
}
