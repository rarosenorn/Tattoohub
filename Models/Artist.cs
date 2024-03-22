using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tattoohub.Models;
public class Artist {
    public int ArtistId {get; set;}
    public int ShopId {get; set;}
    [Required]
    [DataType(DataType.Currency)]
    public decimal? HourlyRate {get; set;}
    [Required]
    [StringLength(100)]   
    public string? InstagramAt {get;set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? FirstName {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]    
    public string? LastName {get; set;}
    [EmailAddress]
    public string? Email {get; set;}
    public Shop? Shop {get; set;}
    public ICollection<Tattoo>? Tattoos {get; set;}
    public ICollection<ArtistStyle>? ArtistStyles {get; set;}
}