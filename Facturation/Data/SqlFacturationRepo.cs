using System.Collections.Generic;
using Facturation.Models;
using System.Linq;
using System;


namespace Facturation.Data
{
  public class SqlFacturationRepo : IFacturationRepo
  {
    private readonly FacturationContext _context;

    //Constructor with DependencyInjection
    public SqlFacturationRepo(FacturationContext context)
    {
      _context = context;
    }


    //Add Client
    public void CreateClient(Client client)
    {
        if(client == null)
          throw new ArgumentNullException(nameof(client));

        _context.Clients.Add(client);
    }


    public void DeleteClient(Client client)
        {
            if(client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            _context.Clients.Remove(client);
        }

    //Save Changes
    public bool SaveChanges()
    {
        return(_context.SaveChanges() >= 0);
    }


    //Return all Clients
    public IEnumerable<Client> GetAllClients()
    {
        return _context.Clients.ToList();
    }

    //Return Client by id
    public Client GetClientById(int id)
    {
        return _context.Clients.FirstOrDefault(p => p.Id == id);
    }

    public void UpdateClient(Client client)
        {
            //Nothing
        }







    //Facture stuff
    public void UpdateFacture(Facture facture)
    {
                //Nothing
    }

    //Return Facture by id
    public Facture GetFactureById(int id)
    {
        return _context.Factures.FirstOrDefault(p => p.Id == id);
    }

    //Return all Factures
    public IEnumerable<Facture> GetAllFactures()
    {
        return _context.Factures.ToList();
    }

    public void DeleteFacture(Facture facture)
        {
            if(facture == null)
            {
                throw new ArgumentNullException(nameof(facture));
            }
            _context.Factures.Remove(facture);
        }

        //Add Facture
      public void CreateFacture(Facture facture)
      {
            if(facture == null)
              throw new ArgumentNullException(nameof(facture));

            _context.Factures.Add(facture);
      }


      //it's devis time

      //Devi stuff
      public void UpdateDevi(Devi devi)
      {
                  //Nothing
      }

      //Return Devi by id
      public Devi GetDeviById(int id)
      {
          return _context.Devis.FirstOrDefault(p => p.Id == id);
      }

      //Return all Devis
      public IEnumerable<Devi> GetAllDevis()
      {
          return _context.Devis.ToList();
      }

      public void DeleteDevi(Devi devi)
          {
              if(devi == null)
              {
                  throw new ArgumentNullException(nameof(devi));
              }
              _context.Devis.Remove(devi);
          }

          //Add Devi
        public void CreateDevi(Devi devi)
        {
              if(devi == null)
                throw new ArgumentNullException(nameof(devi));

              _context.Devis.Add(devi);
        }



  }
}
