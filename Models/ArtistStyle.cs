namespace Tattoohub.Models;
public class ArtistStyle {
    public int ArtistId {get; set;}
    public int StyleId {get; set;}
    public Artist? Artist {get; set;}
    public Style? Style {get; set;}
}
