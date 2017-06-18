using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDemo.Models
{
    public class Affect
    {
        [Key]
        public int AffectId { get; set; }

        [Display(Name = "Affect")]
        public string Name { get; set; }

        public int ProjectId { get; set; }
        
        public ChangeProject Project { get; set; }

    }
}