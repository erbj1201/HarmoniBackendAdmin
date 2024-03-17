using System.ComponentModel.DataAnnotations;

namespace HarmoniBackendAdmin.Models;
// class constructor
public class Treatment{
    //properties
    public int Id {get; set;}
    [Required(ErrorMessage = "Behandlingen måste ha ett namn. Ange ett namn")]
     [Display(Name = "Namn:")]
    public string? TreatmentName {get; set;}
    [Required(ErrorMessage = "Behandlingen måste ha en beskrivning. Ange en beskrivning")]
     [Display(Name = "Beskrivning:")]
    public string? TreatmentDescription {get; set;}
    [Required(ErrorMessage = "Behandlingen måste ha ett pris. Ange ett pris")]
     [Display(Name = "Pris:")]
    public string? TreatmentPrice {get; set;}
     [Required(ErrorMessage = "Behandlingen måste ha en kategori. Välj en kategori")]
     [Display(Name = "Kategori:")]
    public string? TreatmentCategory {get; set;}
    public List <Booking>? Bookingss {get; set;}
}