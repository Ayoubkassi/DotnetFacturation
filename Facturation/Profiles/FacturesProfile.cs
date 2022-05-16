using AutoMapper;
using Facturation.Dtos;
using Facturation.Models;

namespace Facturation.Profiles
{
    public class FacturesProfile : Profile
    {
        public FacturesProfile()
        {
            //Source -> Target
            CreateMap<Facture, FactureReadDto>();
            CreateMap<FactureCreateDto, Facture>();
            CreateMap<FactureUpdateDto , Facture>();
            // CreateMap<Facture , FactureUpdateDto>();
        }

    }

}
