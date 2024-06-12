using System.ComponentModel.DataAnnotations;
namespace MuscatMover.Models
{
    public class login
    {
        [Key]
        public string uname { get; set; }
        public string pass { get; set; }
    }
}
