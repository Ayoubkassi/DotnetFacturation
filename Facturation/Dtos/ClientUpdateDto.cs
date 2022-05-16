using System.ComponentModel.DataAnnotations;

namespace Facturation.Dtos
{
    public class ClientUpdateDto
    {

    [Required]
    public string RS { get; set; }

    [Required]
    public string NomResp { get; set; }

    [Required]
    public string TypeClient { get; set; }

    [Required]
    public string Nom { get; set; }

    [Required]
    public string Prenom { get; set; }

    [Required]
    public string Tel { get; set; }

/*    [Required]
*/    public string Portable { get; set; }

/*    [Required]
*/    public string Fax { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Adresse { get; set; }

    [Required]
    public string Ville { get; set; }

    [Required]
    public string Pays { get; set; }

    [Required]
    public string IF { get; set; }

    [Required]
    public string Patente { get; set; }

    [Required]
    public string ICE { get; set; }

    [Required]
    public string RC { get; set; }
    }

  }
