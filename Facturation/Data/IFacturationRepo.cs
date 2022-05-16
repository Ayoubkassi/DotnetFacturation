using System.Collections.Generic;
using Facturation.Models;

namespace Facturation.Data

{
  public interface IFacturationRepo
  {
    bool SaveChanges();

    IEnumerable<Client> GetAllClients();
    Client GetClientById(int id);
    void UpdateClient(Client client);
    void DeleteClient(Client client);
    void CreateClient(Client client);
    // bool SaveChanges();

    //now it's facture time
    IEnumerable<Facture> GetAllFactures();
    Facture GetFactureById(int id);
    void UpdateFacture(Facture facture);
    void DeleteFacture(Facture facture);
    void CreateFacture(Facture facture);

    //now devi time

    IEnumerable<Devi> GetAllDevis();
    Devi GetDeviById(int id);
    void UpdateDevi(Devi devi);
    void DeleteDevi(Devi devi);
    void CreateDevi(Devi devi);

  }
}
