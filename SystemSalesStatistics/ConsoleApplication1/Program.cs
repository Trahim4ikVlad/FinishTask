using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObjectsLayer;
using DataTransferObjectsLayer.DtoEntity;
using BusinessLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           IDtoEntity model = new ClientViewModel()
           {
               ID = 1,
               Name = "sdfs"
           };

   
            Manager manager = new Manager()
            {
                ID = 1,
                Name = "sfsdf"
            };



            /*ManagerViewModel vieManagerViewModel = Mapper<Manager, ManagerViewModel>.ConvertToDto(manager);

            Client client = Mapper<Client, ClientViewModel>.ConvertToDomain(model);

            ClientViewModel view = Mapper<Client, ClientViewModel>.ConvertToDto(client);

            IList<Client> clients = new Client[]{new Client(){ID = 1,Name = "rep"}, new Client(){ID = 2,Name = "pep"}};

            IEnumerable<ClientViewModel> clientViewModels = Mapper<Client, ClientViewModel>.ConvertToDtos(clients);
            
            foreach (var clientViewModel in clientViewModels)
            {
                Console.WriteLine(clientViewModel.ID+""+clientViewModel.Name);
            }
           */
         
        }
    }
}
