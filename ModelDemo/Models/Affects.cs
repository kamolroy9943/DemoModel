using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDemo.Models
{
    public class Affects
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Affect")]
        public string Name { get; set; }

        [ForeignKey("ChangeProject")]
        public int ChangeProjectId { get; set; }
    }
}