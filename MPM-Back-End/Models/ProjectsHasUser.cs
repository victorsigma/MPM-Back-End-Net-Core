using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPM_Back_End.Models
{
    public class ProjectsHasUser
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("UserData")]
        public string proyectsIdProject { get; set; }

        [Required]
        [ForeignKey("ProjectData")]
        public string userIdUser { get; set; }

        [Required]
        public int rolesIdRol { get; set; }
    }
}
