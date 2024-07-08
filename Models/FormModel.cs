using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required]
        public string? FirstName {  get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Zipcode { get; set; }

        [Required]
        public string? Town { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string? Typeoftraining { get; set; }

        [Required]
        public string? CobolTraining { get; set; }

        [Required]
        public string? TrainingPurpose { get; set; }

    }
}
