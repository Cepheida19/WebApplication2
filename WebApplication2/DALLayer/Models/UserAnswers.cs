
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.DALLayer.Models
{
    public class UserAnswers
    {
        [Key]
        public int Id {get; set;}
        public string Answers { get; set; }
    }
}
