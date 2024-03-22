using Microsoft.EntityFrameworkCore;

namespace Tattoohub.Models;
public static class SeedData
{
    public static void EnsureDbIsPopulated(IApplicationBuilder app)
    {
        DatabaseContext dbContext = app.ApplicationServices
            .CreateScope().ServiceProvider
            .GetRequiredService<DatabaseContext>();
        if (dbContext.Database.GetPendingMigrations().Any())
        {
            dbContext.Database.Migrate();
        }
        if (!dbContext.Articles.Any())
        {
            dbContext.Articles.AddRange
            (
                new Article
                {
                    ArticleName = "Tattoo body placement and pain",
                    Author = "Rasmus",
                    Topic = "Pain",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "History behind Irezumi aka. Japanese Koi Fish Style",
                    Author = "Rasmus",
                    Topic = "Irezumi CultureOrCountryOrigin",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "How old school is the old school/traditional style?",
                    Author = "Rasmus",
                    Topic = "Traditional style CultureOrCountryOrigin",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Historical Tattoo artists",
                    Author = "Rasmus",
                    Topic = "",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Tattoos in indigenous cultures, e.g. Maori",
                    Author = "Rasmus",
                    Topic = "Tattoo Culture",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Overview of Tattoo Styles",
                    Author = "Rasmus",
                    Topic = "Tattoo Styles",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "First Tattoo Guide",
                    Author = "Rasmus",
                    Topic = "Guide",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Famous and Infamous Tattoos (from celebrities, tv-shows etc.)",
                    Author = "Rasmus",
                    Topic = "",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Style Deep Dive: Realism",
                    Author = "Rasmus",
                    Topic = "Style Deep Dive",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Style Deep Dive: Neo Traditional",
                    Author = "Rasmus",
                    Topic = "Style Deep Dive",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Best and Worst Face Tattoos",
                    Author = "Rasmus",
                    Topic = "Face Tattoos",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Style Deep Dive: Realism",
                    Author = "Rasmus",
                    Topic = "Style Deep Dive",
                    DatePublished = DateTime.Now
                },
                new Article
                {
                    ArticleName = "Tattoos and their meanings",
                    Author = "Rasmus",
                    Topic = "Tattoo Meaning",
                    DatePublished = DateTime.Now
                }
            );
            dbContext.SaveChanges();
        }
        if (!dbContext.Shops.Any())
        {
            dbContext.Shops.AddRange
            (
                new Shop
                {
                    Name = "Iron & Ink Aarhus",
                    Owner = "a",
                    OwnerEmailAddress = "a@a.com",
                    Country = "Denmark",
                    Address = "Aarhus Midtby"
                },
                new Shop
                {
                    Name = "Sinners Ink",
                    Owner = "Mark Wosgerau",
                    OwnerEmailAddress = "mw@sinnersink.com",
                    Country = "Denmark",
                    Address = "Taet paa stjernepladsen"
                },
                new Shop
                {
                    Name = "Venlig Hilsen",
                    Owner = "Bjarke",
                    OwnerEmailAddress = "Bjarke@VenligHilsen.com",
                    Country = "Denmark",
                    Address = "Aarhus Midtby"
                }
            );
            dbContext.SaveChanges();
        }
        if (!dbContext.Styles.Any())
        {
            dbContext.Styles.AddRange
            (
                new Style
                {
                    StyleName = "Irezumi/Japenese",
                    Description = "Very cool, Lots of fish and if you have them i Japan people think youre Yakuza (not as cool as it used to be)",
                    CultureOrCountryOrigin = "Japan"
                },
                new Style
                {
                    StyleName = "Old School/Traditional",
                    Description = "Looks like a patch, Coolest style to have if youre not Asian(if you are Irezumi is cooler)",
                    CultureOrCountryOrigin = "The Sea"
                },
                new Style
                {
                    StyleName = "Realism / Photorealism",
                    CultureOrCountryOrigin = "Modern, developed from advancements in tattooing techniques and technology.",
                    Description = "Highly detailed tattoos that aim to replicate the appearance of real-life objects or portraits with precision and accuracy. Often utilize shading and color blending techniques to create depth and realism."
                },
                new Style
                {
                    StyleName = "Neo-Traditional",
                    CultureOrCountryOrigin = "Evolved from traditional tattooing styles, gaining popularity in the late 20th century.",
                    Description = "Similar to traditional tattoos but with a modern twist, incorporating elements of realism, illustrative techniques, and a broader color palette. Features traditional imagery with more intricate detail and creative interpretations."
                },
                new Style
                {
                    StyleName = "New School",
                    CultureOrCountryOrigin = "Emerged in the 1970s and 1980s as a departure from traditional tattooing.",
                    Description = "Bold, exaggerated designs with cartoon-like imagery, vibrant colors, and exaggerated proportions. Often incorporates elements of graffiti art, pop culture, and comic book aesthetics."
                },
                new Style
                {
                    StyleName = "Biomechanical",
                    CultureOrCountryOrigin = "Popularized by artist H.R. Giger in the late 20th century.",
                    Description = "Tattoos that blend organic elements (such as muscles, tendons, and bones) with mechanical or futuristic components (such as gears, wires, and circuitry). Designs create the illusion of the body being part of a biomechanical construct."
                },
                new Style
                {
                    StyleName = "Watercolor",
                    CultureOrCountryOrigin = "Modern, influenced by traditional watercolor painting techniques.",
                    Description = "Tattoos that mimic the appearance of watercolor paintings, with soft edges, blending colors, and translucent effects. Often feature abstract or nature-inspired designs with a fluid, painterly quality."
                },
                new Style
                {
                    StyleName = "Geometric",
                    CultureOrCountryOrigin = "Modern, inspired by geometric shapes and patterns.",
                    Description = "Tattoos composed of geometric shapes, lines, and patterns arranged in intricate designs. Can range from simple geometric symbols to complex, symmetrical patterns."
                },
                new Style
                {
                    StyleName = "Blackwork",
                    CultureOrCountryOrigin = "Ancient, found in various cultures worldwide.",
                    Description = "Tattoos consisting primarily or entirely of black ink, with bold lines and solid areas of black shading. Can include tribal motifs, geometric patterns, or illustrative designs, often with a focus on contrast and negative space."
                }
            );
            dbContext.SaveChanges();
        }
        if (!dbContext.Artists.Any())
        {
            dbContext.Artists.AddRange
            (
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@Alenya.Tattoo",
                    FirstName = "Alenya",
                    LastName = "Pehlivanoglu",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Iron & Ink Aarhus").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@SamsonovTattoo",
                    FirstName = "Bohdan",
                    LastName = "Samsonov",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Iron & Ink Aarhus").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@hitakoosha",
                    FirstName = "Anahita",
                    LastName = "Koosha",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Iron & Ink Aarhus").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@markwosgerau",
                    FirstName = "Mark",
                    LastName = "Wosgerau",
                    Email = "info@sinnersinc.dk",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Sinners Ink").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@andreas.givskov",
                    FirstName = "Andreas",
                    LastName = "Givskov",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Sinners Ink").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@miawosgerau",
                    FirstName = "Mia",
                    LastName = "Wosgerau",
                    Email = "info@sinnersink.dk",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Sinners Ink").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@bjarke.andersen",
                    FirstName = "Bjarke",
                    LastName = "Andersen",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Venlig Hilsen").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@rass.ansoe",
                    FirstName = "Rass",
                    LastName = "Ansoe",
                    Email = "",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Venlig Hilsen").ShopId
                },
                new Artist
                {
                    HourlyRate = 100,
                    InstagramAt = "@jakobxtattoos",
                    FirstName = "Jakob",
                    LastName = "x",
                    Email = "jakobtattoos@gmail.com",
                    ShopId = dbContext.Shops.Single(s => s.Name == "Venlig Hilsen").ShopId
                }
            );
            dbContext.SaveChanges();
        };
        if (!dbContext.ArtistStyles.Any())
        {
            dbContext.ArtistStyles.AddRange(
                new ArtistStyle { ArtistId = 2, StyleId = 1 },
                new ArtistStyle { ArtistId = 2, StyleId = 2 },
                new ArtistStyle { ArtistId = 3, StyleId = 3 },
                new ArtistStyle { ArtistId = 4, StyleId = 4 },
                new ArtistStyle { ArtistId = 5, StyleId = 5 },
                new ArtistStyle { ArtistId = 6, StyleId = 6 },
                new ArtistStyle { ArtistId = 7, StyleId = 7 },
                new ArtistStyle { ArtistId = 8, StyleId = 8 },
                new ArtistStyle { ArtistId = 9, StyleId = 9 },
                new ArtistStyle { ArtistId = 3, StyleId = 2 },
                new ArtistStyle { ArtistId = 2, StyleId = 3 },
                new ArtistStyle { ArtistId = 3, StyleId = 4 },
                new ArtistStyle { ArtistId = 4, StyleId = 5 },
                new ArtistStyle { ArtistId = 5, StyleId = 6 },
                new ArtistStyle { ArtistId = 6, StyleId = 7 },
                new ArtistStyle { ArtistId = 7, StyleId = 8 },
                new ArtistStyle { ArtistId = 8, StyleId = 9 },
                new ArtistStyle { ArtistId = 9, StyleId = 1 },
                new ArtistStyle { ArtistId = 4, StyleId = 3 },
                new ArtistStyle { ArtistId = 2, StyleId = 4 },
                new ArtistStyle { ArtistId = 3, StyleId = 5 },
                new ArtistStyle { ArtistId = 4, StyleId = 6 },
                new ArtistStyle { ArtistId = 5, StyleId = 7 },
                new ArtistStyle { ArtistId = 6, StyleId = 8 },
                new ArtistStyle { ArtistId = 7, StyleId = 9 },
                new ArtistStyle { ArtistId = 8, StyleId = 1 },
                new ArtistStyle { ArtistId = 9, StyleId = 2 },
                new ArtistStyle { ArtistId = 10, StyleId = 4 },
                new ArtistStyle { ArtistId = 10, StyleId = 5 },
                new ArtistStyle { ArtistId = 3, StyleId = 6 }
            );
            dbContext.SaveChanges();
        }
        if (!dbContext.Tattoos.Any())
        {
            dbContext.Tattoos.AddRange(

                new Tattoo
                {
                    Likeness = "Rose",
                    TattooSize = TattooSize.Small,
                    BodyPlacement = BodyPlacement.Chest,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@Alenya.Tattoo").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Ship",
                    TattooSize = TattooSize.Medium,
                    BodyPlacement = BodyPlacement.Back,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@SamsonovTattoo").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Potato",
                    TattooSize = TattooSize.Huge,
                    BodyPlacement = BodyPlacement.Leg,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@hitakoosha").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Boxer",
                    TattooSize = TattooSize.Big,
                    BodyPlacement = BodyPlacement.Arm,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@markwosgerau").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Swallow",
                    TattooSize = TattooSize.Small,
                    BodyPlacement = BodyPlacement.Foot,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@andreas.givskov").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Pizza Slice",
                    TattooSize = TattooSize.Medium,
                    BodyPlacement = BodyPlacement.Face,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@miawosgerau").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Sexy lady",
                    TattooSize = TattooSize.Medium,
                    BodyPlacement = BodyPlacement.Arm,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@bjarke.andersen").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Keyboard",
                    TattooSize = TattooSize.Huge,
                    BodyPlacement = BodyPlacement.Back,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@rass.ansoe").ArtistId
                },
                new Tattoo
                {
                    Likeness = "Coffee cup",
                    TattooSize = TattooSize.Medium,
                    BodyPlacement = BodyPlacement.Hand,
                    ArtistId = dbContext.Artists.Single(a => a.InstagramAt == "@jakobxtattoos").ArtistId
                }
            );
            dbContext.SaveChanges();
        }
    }
}



