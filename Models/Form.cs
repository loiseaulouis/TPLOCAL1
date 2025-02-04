using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Adresse { get; set; }
        [RegularExpression("[0-9]{5}")]
        [Required]
        public string CodePostal { get; set; }
        [Required]
        public string Ville { get; set; }
        [RegularExpression("^([\\w]+)@([\\w]+).([\\w]+)$")]
        [Required]
        public string AdresseEmail { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly? DateDeb { get; set; }
       
        [Required]
        public string Formation { get; set; }
        public string? AvisCBL { get; set; }
        public string? AvisDotNET { get; set; }
    }
}