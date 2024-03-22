using System.ComponentModel.DataAnnotations;

namespace Tattoohub.Models;
public class Article {
    public int ArticleId {get; set;}
    [Required]
    [StringLength(200)]
    [Display(Name = "Title")]
    public string? ArticleName {get; set;}
    [Required]
    [StringLength(200)]
    public string? Author {get; set;}
    [Required]
    [StringLength(100)]
    public string? Topic {get; set;}
    [Required]
    [DataType(DataType.Date)]
    public DateTime DatePublished {get; set;}
}