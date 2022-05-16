using System.ComponentModel.DataAnnotations;

namespace Facturation.Models

{
    public class Facture
    {
      [Key]
      [Required]
      public int Id { get; set; }

      [Required]
      public string RS { get; set; }

      [Required]
      public string Designation { get; set; }

      [Required]
      public string Status { get; set; }

      [Required]
      public int Quantite { get; set; }

      [Required]
      public int Prix { get; set; }

      [Required]
      public string Date { get; set; }

      [Required]
      public string Total { get; set; }

      [Required]
      public string Reference { get; set; }

      [Required]
      public string ClientId { get; set; }


    }
}
