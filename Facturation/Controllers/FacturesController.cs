using Microsoft.AspNetCore.Mvc;
using Facturation.Data;
using Facturation.Dtos;
using Facturation.Models;
using System.Collections.Generic;
using AutoMapper;

namespace Facturation.Controllers

{
  [Route("api/v1/factures")]
  [ApiController]
  public class FacturesController : ControllerBase
  {
    private readonly IFacturationRepo _repository;
    private readonly IMapper _mapper;


    //constructor

    public FacturesController(IFacturationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    //GET api/v1/factures
    [HttpGet]
    public ActionResult <IEnumerable<FactureReadDto>> GetAllFactures()
    {
      var factureItems = _repository.GetAllFactures();

      return Ok(_mapper.Map<IEnumerable<FactureReadDto>>(factureItems));
    }

    //GET api/v1/factures/{id}
    [HttpGet("{id}", Name="GetFactureById")]
    public ActionResult <FactureReadDto> GetFactureById(int id)
    {
      var factureItem = _repository.GetFactureById(id);
      if(factureItem !=  null)
        return Ok(_mapper.Map<FactureReadDto>(factureItem));
      //NO Id in DB
      return NotFound();
    }

    //POST api/factures
        [HttpPost]
        public ActionResult <FactureReadDto> CreateFacture(FactureCreateDto factureCreateDto)
        {
            var factureModel = _mapper.Map<Facture>(factureCreateDto);
            _repository.CreateFacture(factureModel);
            _repository.SaveChanges();

            var factureReadDto = _mapper.Map<FactureReadDto>(factureModel);

            return CreatedAtRoute(nameof(GetFactureById), new {Id = factureReadDto.Id}, factureReadDto);
        }

        //PUT api/factures/{id}
          [HttpPut("{id}")]
          public ActionResult UpdateFacture(int id, FactureUpdateDto factureUpdateDto)
          {
              var factureModelFromRepo = _repository.GetFactureById(id);
              if(factureModelFromRepo == null)
              {
                  return NotFound();
              }
              _mapper.Map(factureUpdateDto, factureModelFromRepo);

              _repository.UpdateFacture(factureModelFromRepo);

              _repository.SaveChanges();

              return NoContent();
          }




        //DELETE api/factures/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteFacture(int id)
        {
            var factureModelFromRepo = _repository.GetFactureById(id);
            if(factureModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteFacture(factureModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

  }
}
