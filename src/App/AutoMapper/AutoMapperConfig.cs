using App.ViewModels;
using AutoMapper;
using Business.Models;

namespace App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {


        public AutoMapperConfig()
        {

            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Evento, EventoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<EnderecoEvento, EnderecoEventoViewModel>().ReverseMap();
        }

    }
}
