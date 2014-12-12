using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObjectsLayer;
using DataTransferObjectsLayer.DtoEntity;

namespace BusinessLayer
{
    public class Worker:IWorker
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IManagerRepository _managerRepository;

        public Worker()
        {
         _orderRepository = new OrderRepository();
         _clientRepository = new ClientRepository();
         _managerRepository = new ManagerRepository();
        }

        public Worker(IOrderRepository orderRepository, IClientRepository clientRepository, IManagerRepository managerRepository)
        {
            _orderRepository = orderRepository;
            _clientRepository = clientRepository;
            _managerRepository = managerRepository;
        }

        public IList<OrderViewModel> GetAllOrders()
        {
            return _orderRepository.GetAll().Select(Mapper<Order,OrderViewModel>.ConvertToDto).ToList();
        }

        /*
        public IList<OrderViewModel> FilterByDate(DateTime date)
        {
            return _orderRepository.GetList(order => order.OrderDate == date).Select(Mapper<Order, OrderViewModel>.ConvertToDto).ToList();
        }

        public IList<OrderViewModel> FilterManager(string managerName)
        {
            return _orderRepository.GetList(order => order.Manager.Name == managerName).Select(Mapper<Order, OrderViewModel>.ConvertToDto).ToList();
        }

        public IList<OrderViewModel> FilterProduct(string productName)
        {
            return
                _orderRepository.GetList(order => order.ProductName == productName)
                    .Select(Mapper<Order, OrderViewModel>.ConvertToDto).ToList();
        }
        */

        public IList<OrderViewModel> FilterBy(Func<Order, bool> where)
        {
            return _orderRepository.GetList(where).Select(Mapper<Order, OrderViewModel>.ConvertToDto).ToList();
        }

        public void AddOrder(params OrderViewModel[] orderViewModels)
        {
            _orderRepository.Add(Mapper<Order,OrderViewModel>.ConvertToDomains(orderViewModels).ToArray());
        }

        public void UpdateOrder(params OrderViewModel[] orderViewModels)
        {
            _orderRepository.Update(Mapper<Order, OrderViewModel>.ConvertToDomains(orderViewModels).ToArray());
        }

        public void RemoveOrder(params OrderViewModel[] orderViewModels)
        {
            _orderRepository.Remove(Mapper<Order, OrderViewModel>.ConvertToDomains(orderViewModels).ToArray());
        }

        public void AddClient(params ClientViewModel[] clientViewModels)
        {
            _clientRepository.Add(Mapper<Client, ClientViewModel>.ConvertToDomains(clientViewModels).ToArray());
        }

        public void UpdateClient(params ClientViewModel[] clientViewModels)
        {
            _clientRepository.Update(Mapper<Client, ClientViewModel>.ConvertToDomains(clientViewModels).ToArray());
        }

        public void RemoveClient(params ClientViewModel[] clientViewModels)
        {
            _clientRepository.Update(Mapper<Client, ClientViewModel>.ConvertToDomains(clientViewModels).ToArray());
        }

        public void AddManager(params ManagerViewModel[] managerViewModels)
        {
            _managerRepository.Add(Mapper<Manager, ManagerViewModel>.ConvertToDomains(managerViewModels).ToArray());
        }

        public void UpdateManager(params ManagerViewModel[] managerViewModels)
        {
            _managerRepository.Update(Mapper<Manager, ManagerViewModel>.ConvertToDomains(managerViewModels).ToArray());
        }

        public void RemoveManager(params ManagerViewModel[] managerViewModels)
        {
            _managerRepository.Remove(Mapper<Manager, ManagerViewModel>.ConvertToDomains(managerViewModels).ToArray());
        }


        public IList<OrderViewModel> FilterBy(params Expression<Func<Order, object>>[] navigationProperties)
        {
            return _orderRepository.GetAll(navigationProperties).Select(Mapper<Order, OrderViewModel>.ConvertToDto).ToList();
        }
    }
}
