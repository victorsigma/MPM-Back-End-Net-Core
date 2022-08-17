using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPM_Back_End.Models
{
    public class ActivityData
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
        public int status { get; set; }

        [Required]
        public DateTime dateEnd { get; set; }

        [Required]
        public bool Leader { get; set; }
        [Required]
        public bool Analyst { get; set; }
        [Required]
        public bool Designer { get; set; }
        [Required]
        public bool Programmer { get; set; }

        [Required]
        [ForeignKey("ProjectData")]
        public string projectId { get; set; }
    }
}
