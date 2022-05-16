using Microsoft.AspNetCore.Mvc;
using Facturation.Data;
using Facturation.Dtos;
using Facturation.Models;
using System.Collections.Generic;
using AutoMapper;

namespace Facturation.Controllers

{
  [Route("api/v1/devis")]
  [ApiController]
  public class DevisController : ControllerBase
  {
    private readonly IFacturationRepo _repository;
    private readonly IMapper _mapper;

    //constructor

    public DevisController(IFacturationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/v1/devis
        [HttpGet]
        public ActionResult <IEnumerable<DeviReadDto>> GetAllDevis()
        {
          var deviItems = _repository.GetAllDevis();

          return Ok(_mapper.Map<IEnumerable<DeviReadDto>>(deviItems));
        }

        //GET api/v1/clients/{id}
        [HttpGet("{id}", Name="GetDeviById")]
        public ActionResult <DeviReadDto> GetDeviById(int id)
        {
          var deviItem = _repository.GetDeviById(id);
          if(deviItem !=  null)
            return Ok(_mapper.Map<DeviReadDto>(deviItem));
          //NO Id in DB
          return NotFound();
        }

        //POST api/devis
          [HttpPost]
          public ActionResult <DeviReadDto> CreateDevi(DeviCreateDto deviCreateDto)
          {
              var deviModel = _mapper.Map<Devi>(deviCreateDto);
              _repository.CreateDevi(deviModel);
              _repository.SaveChanges();

              var deviReadDto = _mapper.Map<DeviReadDto>(deviModel);

              return CreatedAtRoute(nameof(GetDeviById), new {Id = deviReadDto.Id}, deviReadDto);
          }

          //PUT api/devis/{id}
             [HttpPut("{id}")]
             public ActionResult UpdateDevi(int id, DeviUpdateDto deviUpdateDto)
             {
                 var deviModelFromRepo = _repository.GetDeviById(id);
                 if(deviModelFromRepo == null)
                 {
                     return NotFound();
                 }
                 _mapper.Map(deviUpdateDto, deviModelFromRepo);

                 _repository.UpdateDevi(deviModelFromRepo);

                 _repository.SaveChanges();

                 return NoContent();
             }


             //DELETE api/devis/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteDevi(int id)
            {
                var deviModelFromRepo = _repository.GetDeviById(id);
                if(deviModelFromRepo == null)
                {
                    return NotFound();
                }
                _repository.DeleteDevi(deviModelFromRepo);
                _repository.SaveChanges();

                return NoContent();
            }



      }

}
