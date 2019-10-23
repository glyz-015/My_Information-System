using System;
using System.ComponentModel.DataAnnotations;

namespace CUMCIS.Models
{
    public class Myembro
    {
        public int id {get; set;}
        public string fname {get; set;}
        public string lname {get; set;}
        public string suffix {get; set;}
        public string gender {get; set;}
        
        public DateTime bdate {get; set;}
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public int age {get; set;}
        public string grp {get; set;}
        public string contact {get; set;}
        public string email {get; set;}
        public string address {get; set;}
        public string stat {get; set;}
        public string mname {get; set;}
        public string marital {get; set;}
        public string husbandname {get; set;}
        public string wifename {get; set;}
        public string children {get; set;}
        public DateTime anniv {get; set;}
        public DateTime dod {get; set;}

 
    }
}