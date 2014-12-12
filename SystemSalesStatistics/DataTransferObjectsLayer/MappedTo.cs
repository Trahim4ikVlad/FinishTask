using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer;

namespace DataTransferObjectsLayer
{
    public abstract class MappedTo<T> where T : class
    {
        protected MappedTo()
        {
            Mapper.CreateMap(GetType(), typeof(T));
        }

        public T Convert()
        {
            return (T) Mapper.Map(this, this.GetType(), typeof (T));
        }
    }
}
