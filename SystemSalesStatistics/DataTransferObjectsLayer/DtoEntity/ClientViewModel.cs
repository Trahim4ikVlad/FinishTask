using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataTransferObjectsLayer.DtoEntity
{
    public class ClientViewModel : MappedTo<Client>, IDtoEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

       
    }
}
