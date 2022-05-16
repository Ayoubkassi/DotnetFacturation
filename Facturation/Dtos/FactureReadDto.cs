using System.ComponentModel.DataAnnotations;

namespace Facturation.Dtos
{
    public class FactureReadDto
    {


      public int Id { get; set; }

      public string RS { get; set; }

      public string Designation { get; set; }

      public string Status { get; set; }

      public int Quantite { get; set; }

      public int Prix { get; set; }

      public string Date { get; set; }

      public string Total { get; set; }

      public string Reference { get; set; }

      public string ClientId { get; set; }

    }

}
