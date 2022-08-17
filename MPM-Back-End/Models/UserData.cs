using System.ComponentModel.DataAnnotations;

namespace MPM_Back_End.Models
{
    public class UserData
    {
        [Key]
        public string userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string userMail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string phoneNumber { get; set; }
    }
}
