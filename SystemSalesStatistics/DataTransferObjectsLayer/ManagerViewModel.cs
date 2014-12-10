using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataTransferObjectsLayer
{
    public class ManagerViewModel:MappedTo<Manager>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
