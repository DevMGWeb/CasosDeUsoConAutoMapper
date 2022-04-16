using AutoMapper;
using AutoMapperMVC.Models;
using System.Linq.Expressions;

namespace AutoMapperMVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BeerRequest, Beer>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Nombre))
                .ForMember(d => d.Price, o => o.MapFrom(mappearSiEsQueTienePrecio))
                .ForMember(d => d.idCategory, o => o.Ignore());
        }

        private decimal mappearSiEsQueTienePrecio(BeerRequest beerRequest, Beer beer)
        {
            beer.Price = 10;

            if(beerRequest.Precio == 0)
            {
                return beer.Price;
            }

            return beerRequest.Precio;
        }
    }
}
