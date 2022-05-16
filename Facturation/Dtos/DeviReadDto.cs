using System.ComponentModel.DataAnnotations;

namespace Facturation.Dtos
{
    public class DeviReadDto
    {
      public int Id { get; set; }

      public string RS { get; set; }

      public int Quantite { get; set; }

      public int Total { get; set; }

      public string Date { get; set; }

      public int ClientId { get; set; }

      public string Status { get; set; }

      public int DevisNumber { get; set; }
    }

}
