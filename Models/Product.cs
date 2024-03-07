//Include
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//namespace
namespace HarmoniBackendAdmin.Models;

//class constructor
public class Product
{
    //properties
    public int Id { get; set; }

    [Required(ErrorMessage = "Produkten måste ha ett namn. Ange ett produktnamn")]
    [Display(Name = "Namn:")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Produkten måste ha ett pris. Ange ett pris")]
    [Display(Name = "Pris:")]
    public string? ProductPrice { get; set; }
    
    [Required(ErrorMessage = "Produkten måste ha en kategori. Välj en kategori")]
    [Display(Name = "Kategori:")]
    public string? ProductCategory { get; set; }
    [Display(Name = "Bild:")]
    public string? ProductImageName { get; set; }

    [Display(Name = "Bild:")]
    [NotMapped]
    public IFormFile? ProductImageFile { get; set; }
}
