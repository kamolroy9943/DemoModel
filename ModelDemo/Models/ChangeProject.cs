using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class ChangeProject
    {

        public string ProjectName { get; set; }
        public DateTime Date { get; set; }
        public string ChangeRequestor { get; set; }
        public string ChangeNo { get; set; }
        public ICollection<Catagory> ChangeCatagory { get; set; }
        public ICollection<Affects> ChangeAffects { get; set; }
        public string RequestedChange { get; set; }
        public string ChangeReason { get; set; }
        public string AlternativeConsideration { get; set; }
        public string TechnicalChanges { get; set; }
        public string RistConsiderationn { get; set; }
        public double ReasourceCost { get; set; }
        public string ImplementationQuality { get; set; }
        public bool Deposition { get; set; }
        public string Justification { get; set; } 
    }
}