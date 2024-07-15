using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksDukan.Models{

public class Products{
    [Key]
    
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    [DisplayName("Book Title")]
    public string Title { get; set; }
    
    [Required]
    [MaxLength(30)]
    [DisplayName("Author Name")]
    public string Author {get;set;}

  
    [MaxLength(100)]
    [DisplayName("About Content")]
    public string Description{get;set;}

    [Required]
    [Range(1,1000)]
    [DisplayName("Per Book Price for 1 - 49")]

    public double Price {get;set;}

    [Range(1,1000)]
    [DisplayName("Per Book Price for 50+")]

    public double Price50 {get;set;}

    [Range(1,1000)]
    [DisplayName("Per Book Price for 100+")]

    public double Price100 {get;set;}

    











} 
}