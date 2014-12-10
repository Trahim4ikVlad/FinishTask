using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class ClientRepository:GenericDataRepository<Client>, IClientRepository
    {
    }
    public interface IClientRepository : IGenericDataRepository<Client>
    {
    }

}
