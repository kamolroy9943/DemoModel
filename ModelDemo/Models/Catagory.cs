using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Configuration;

namespace ModelDemo.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Catagory")]
        public string Name { get; set; }

        [ForeignKey("ChangeProject")]
        public int ChangeProjectId { get; set; }
    }
}