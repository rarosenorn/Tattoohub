using System.ComponentModel.DataAnnotations;

namespace Tattoohub.Models;

public enum BodyPlacement
{
    Arm,
    Leg,
    Back,
    Chest,
    Neck,
    Face,
    Hand,
    Foot
}
public enum TattooSize 
{
    Tiny,
    Small,
    Medium,
    Big,
    Huge
}
public class Tattoo {
    public int TattooId {get; set;}
    [Required]
    [StringLength(100)]   
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "FirstName can only contain english letters")]
    public string? Likeness {get; set;}
    [Required]
    public TattooSize? TattooSize {get; set;}
    [Required]
    public BodyPlacement? BodyPlacement {get; set;}
    public int ArtistId {get; set;}
    public Artist? Artist {get; set;}
    
} 