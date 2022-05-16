using AutoMapper;
using Facturation.Dtos;
using Facturation.Models;

namespace Facturation.Profiles
{
    public class DevisProfile : Profile
    {
        public DevisProfile()
        {
            //Source -> Target
            CreateMap<Devi, DeviReadDto>();
            CreateMap<DeviCreateDto, Devi>();
            CreateMap<DeviUpdateDto , Devi>();
            // CreateMap<Facture , FactureUpdateDto>();
        }

    }

}
