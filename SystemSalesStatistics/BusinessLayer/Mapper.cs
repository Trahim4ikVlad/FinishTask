using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer;
using DataTransferObjectsLayer;
using DataTransferObjectsLayer.DtoEntity;

namespace BusinessLayer
{
    public  static class Mapper<T,U> where T:IDomainEntity where U:IDtoEntity, new ()
    {

        public static T ConvertToDomain(U dtoEntity)
        {
           Mapper.CreateMap<U,T>();
           return  Mapper.Map<U, T>(dtoEntity);
        }

        public static U ConvertToDto(T domain)
        {
            Mapper.CreateMap<T, U>();
            return Mapper.Map<T, U>(domain);
        }

        public static IEnumerable<T> ConvertToDomains(IEnumerable<U> listDtoEntities)
        {
            Mapper.CreateMap<U, T>();
            return Mapper.Map<IEnumerable<U>, IEnumerable<T>>(listDtoEntities);
        }

        public static IEnumerable<U> ConvertToDtos(IEnumerable<T> listDtoEntities)
        {
            Mapper.CreateMap<T, U>();
            return Mapper.Map<IEnumerable<T>, IEnumerable<U>>(listDtoEntities);
        }

    }
}
