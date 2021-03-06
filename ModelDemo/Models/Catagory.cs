using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Configuration;

namespace ModelDemo.Models
{
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }

        [Display(Name = "Catagory")]
        public string Name { get; set; }

        public int ProjectId { get; set; }

        public ChangeProject Project { get; set; }
    }
}