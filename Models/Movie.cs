using System.ComponentModel.DataAnnotations;

namespace Santarsieri.Andrea.WebCrud.Models;

public class Movie
{
    public int Id {get; set;}
    [Display(Name = "Titolo",    
        Prompt = "Inserire il titolo...", Description="Titolo del film")]  
    public string? Title{get;set;}

    
    [Display(Name = "Data di pubblicazione",    
        Prompt = "Inserire la data di pubblicazione", Description="Data di pubblicazione del film")]  
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get;set;}
     [Display(Name = "Genere Musicale",    
        Prompt = "Inserire il genere...", Description="Genere del film")]  
    public string? Genre {get;set;}
     [Display(Name = "Prezzo",    
        Prompt = "Inserire il prezzo...", Description="Prezzo in euro del film")]  
    public decimal Price {get;set;}
}