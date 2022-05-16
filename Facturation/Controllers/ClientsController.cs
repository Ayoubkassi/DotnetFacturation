using Microsoft.AspNetCore.Mvc;
using Facturation.Data;
using Facturation.Dtos;
using Facturation.Models;
using System.Collections.Generic;
using AutoMapper;

namespace Facturation.Controllers

{
  [Route("api/v1/clients")]
  [ApiController]
  public class ClientsController : ControllerBase
  {
    private readonly IFacturationRepo _repository;
    private readonly IMapper _mapper;


    //constructor

    public ClientsController(IFacturationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    //GET api/v1/clients
    [HttpGet]
    public ActionResult <IEnumerable<ClientReadDto>> GetAllClients()
    {
      var clientItems = _repository.GetAllClients();

      return Ok(_mapper.Map<IEnumerable<ClientReadDto>>(clientItems));
    }

    //GET api/v1/clients/{id}
    [HttpGet("{id}", Name="GetClientById")]
    public ActionResult <ClientReadDto> GetClientById(int id)
    {
      var clientItem = _repository.GetClientById(id);
      if(clientItem !=  null)
        return Ok(_mapper.Map<ClientReadDto>(clientItem));
      //NO Id in DB
      return NotFound();
    }

    //POST api/clients
      [HttpPost]
      public ActionResult <ClientReadDto> CreateClient(ClientCreateDto clientCreateDto)
      {
          var clientModel = _mapper.Map<Client>(clientCreateDto);
          _repository.CreateClient(clientModel);
          _repository.SaveChanges();

          var clientReadDto = _mapper.Map<ClientReadDto>(clientModel);

          return CreatedAtRoute(nameof(GetClientById), new {Id = clientReadDto.Id}, clientReadDto);
      }

      //PUT api/clients/{id}
         [HttpPut("{id}")]
         public ActionResult UpdateClient(int id, ClientUpdateDto clientUpdateDto)
         {
             var clientModelFromRepo = _repository.GetClientById(id);
             if(clientModelFromRepo == null)
             {
                 return NotFound();
             }
             _mapper.Map(clientUpdateDto, clientModelFromRepo);

             _repository.UpdateClient(clientModelFromRepo);

             _repository.SaveChanges();

             return NoContent();
         }


         //DELETE api/clients/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            var clientModelFromRepo = _repository.GetClientById(id);
            if(clientModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteClient(clientModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }





  }
}
