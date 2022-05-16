using System.ComponentModel.DataAnnotations;

namespace Facturation.Dtos
{
    public class DeviCreateDto
    {


      [Required]
      public string RS { get; set; }

      [Required]
      public int Quantite { get; set; }

      [Required]
      public int Total { get; set; }

      [Required]
      public string Date { get; set; }

      [Required]
      public int ClientId { get; set; }

      [Required]
      public string Status { get; set; }

      [Required]
      public int DevisNumber { get; set; }
    }

}
