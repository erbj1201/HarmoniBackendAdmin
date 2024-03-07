//Include
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//namespace
namespace HarmoniBackendAdmin.Models;
//class constructor
 public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Namn måste anges. Ange ett för- och efternamn")]
        [Display(Name = "Namn:")]
        public string? BookingName { get; set; }

        [Required(ErrorMessage = "Mejladress måste anges. Ange en mejladress")]
        [EmailAddress]
        [Display(Name = "Mejladress:")]
        public string? BookingEmail { get; set; }

        [Required(ErrorMessage = "Telefonnummer måste anges. Ange ett telefonnummer")]
        [Display(Name = "Telefonnummer:")]
        [Phone]
        public string? BookingPhone { get; set; }

        [Required(ErrorMessage = "Datum måste väljas. Välj ett datum")]
        [Display(Name = "Datum:")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Du måste välja en behandling")]
        [Display(Name = "Behandling:")]
        public int TreatmentId { get; set; }
        [Display(Name = "Behandling:")]
        public Treatment? Treatments { get; set; }
    }


