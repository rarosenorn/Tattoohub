using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tattoohub.Models;
public class Style {
    public int StyleId {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? StyleName {get; set;}
    [Required]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? Description {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? CultureOrCountryOrigin {get; set;}
    public ICollection<ArtistStyle>? ArtistStyles {get; set;}
}