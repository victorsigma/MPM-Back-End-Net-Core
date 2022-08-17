using System.ComponentModel.DataAnnotations;

namespace MPM_Back_End.Models
{
    public class ProjectData
    {
        [Key]
        public string id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string subtitle { get; set; }

        [Required]
        public string src { get; set; }

        [Required]
        public DateTime dateStart { get; set; }

        [Required]
        public DateTime dateEnd { get; set; }
    }
}
