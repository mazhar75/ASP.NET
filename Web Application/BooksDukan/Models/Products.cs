using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksDukan.Models{

public class Products{
    [Key]
    
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    [DisplayName("Book Title")]
    public string Title { get; set; }

    [Required]
    [MaxLength(15)]
    public string ISBN {get;set;}
    
    [Required]
    [MaxLength(30)]
    [DisplayName("Author Name")]
    public string Author {get;set;}

  
    [MaxLength(100)]
    [DisplayName("About Content")]
    public string Description{get;set;}

    [Required]
    [Range(1,1000)]
    [DisplayName("Price")]

    public double Price {get;set;}

    [Range(1,1000)]
    [DisplayName("Per Book Price for 50+")]

    public double Price50 {get;set;}

    [Range(1,1000)]
    [DisplayName("Per Book Price for 100+")]

    public double Price100 {get;set;}
    [Required]
    public int CategoryId {get;set;}
    [ForeignKey("CategoryId")]
    public Category Category {get;set;}
    public string ImageUrl {get;set;}


    











} 
}