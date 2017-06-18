using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class ChangeProject
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display]
        public string ChangeRequestor { get; set; }

        [Required]
        [Display(Name = "Change No")]
        public string ChangeNo { get; set; }

        [Required]
        [Display(Name = "Catagory")]
        public ICollection<Catagory> ChangeCatagorys { get; set; }

        [Required]
        [Display(Name = "Affect")]
        public ICollection<Affect> ChangeAffects { get; set; }

        [Required]
        [Display(Name = "Requested Change:")]
        public string RequestedChange { get; set; }

        [Required]
        [Display(Name = "Change Reason")]
        public string ChangeReason { get; set; }

        [Required]
        [Display(Name = "Consideration")]
        public string AlternativeConsideration { get; set; }

        [Required]
        [Display(Name = "Technical Changes")]
        public string TechnicalChanges { get; set; }

        [Required]
        [Display(Name = "Risk Considerationn")]
        public string RiskConsiderationn { get; set; }

        [Required]
        [Display(Name = "Resource Cost")]
        public double ReasourceCost { get; set; }

        [Required]
        [Display(Name = "Implementation Quality")]
        public string ImplementationQuality { get; set; }

        [Required]
        [Display(Name = "Deposition")]
        public ICollection<Deposition> Depositions { get; set; }

        [Required]
        [Display(Name = "Justification")]
        public string Justification { get; set; } 
    }
}