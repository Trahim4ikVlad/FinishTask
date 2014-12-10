using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataTransferObjectsLayer
{
    public class OrderViewModel:MappedTo<Order>
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int ManagerID { get; set; }
        public int ClientID { get; set; }
        public string ProductName { get; set; }
        public double Cost { get; set; }
    }
}
