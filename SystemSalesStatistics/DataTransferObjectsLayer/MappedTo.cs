using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataTransferObjectsLayer
{
    public abstract class MappedTo<T>
    {
        public MappedTo()
        {
            Mapper.CreateMap(GetType(), typeof(T));
        }

        public T Convert()
        {
            return (T) Mapper.Map(this, this.GetType(), typeof (T));
        }
    }
}
