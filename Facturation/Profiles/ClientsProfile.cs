using AutoMapper;
using Facturation.Dtos;
using Facturation.Models;

namespace Facturation.Profiles
{
    public class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            //Source -> Target
            CreateMap<Client, ClientReadDto>();
            CreateMap<ClientCreateDto, Client>();
            CreateMap<ClientUpdateDto , Client>();
            // CreateMap<Client , ClientUpdateDto>();
        }

    }

}
