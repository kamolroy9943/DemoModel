using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class Deposition
    {
        [Key]
        public int DepositionId { get; set; }
        public string Name { get; set; }

        public int ProjectId { get; set; }
        
        public ChangeProject Project { get; set; }

        

    }
}