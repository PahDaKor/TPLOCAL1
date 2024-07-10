using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName {  get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [RegularExpression("[0-9][0-9][0-9][0-9][0-9]",ErrorMessage = "Must be of format nnnnn")]
        public string? Zipcode { get; set; }

        [Required]
        public string? Town { get; set; }

        [Required]
        [RegularExpression("^[\\w\\-\\.]+@([\\w-]+\\.)+[\\w-]{2,}$", ErrorMessage = "Please put an email")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Starting Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Type of Training")]
        public string? Typeoftraining { get; set; }

        [Display(Name = "Cobol Training")]
        public string? CobolTraining { get; set; }

        [Display(Name = "Purpose of Training")]
        public string? TrainingPurpose { get; set; }

    }
}
