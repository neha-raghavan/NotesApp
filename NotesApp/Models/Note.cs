using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        [Key]
        public int Note_Id { get; set; }

  

        [Required]
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
    }
}
