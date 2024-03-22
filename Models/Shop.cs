using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tattoohub.Models;
public class Shop {
    public int ShopId {get; set;}
    [Required]
    [StringLength(100)]   
    public string? Name {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? Owner {get; set;}
    [Required]
    [EmailAddress]
    public string? OwnerEmailAddress {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? Country {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "FirstName can only contain alphanumerical characters")]
    public string? Address {get; set;}
    public ICollection<Artist>? Artists {get; set;}
}