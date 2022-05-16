using System.ComponentModel.DataAnnotations;

namespace Facturation.Dtos
{
    public class ClientReadDto
    {

      public int Id { get; set; }

      public string RS { get; set; }

      public string NomResp { get; set; }

      public string TypeClient { get; set; }

      public string Nom { get; set; }

      public string Prenom { get; set; }

      public string Tel { get; set; }

      public string Portable { get; set; }

      public string Fax { get; set; }

      public string Email { get; set; }

      public string Adresse { get; set; }

      public string Ville { get; set; }

      public string Pays { get; set; }

      public string IF { get; set; }

      public string Patente { get; set; }

      public string ICE { get; set; }

      public string RC { get; set; }
    }

  }
