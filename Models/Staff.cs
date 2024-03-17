//Include
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//namespace
namespace HarmoniBackendAdmin.Models;
//class constructor
public class Staff{
    //properties
    public int Id {get; set;}
    [Required(ErrorMessage = "Namn måste anges. Ange ett för- och efternamn")]
     [Display(Name = "Namn:")]
    public string? StaffName {get; set;}
}


    