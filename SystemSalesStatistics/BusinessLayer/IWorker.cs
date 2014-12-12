using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObjectsLayer;
using DataTransferObjectsLayer.DtoEntity;

namespace BusinessLayer
{
    public interface IWorker
    {
        IList<OrderViewModel> GetAllOrders();

        
        IList<OrderViewModel> FilterBy(Func<Order,bool> where);
        IList<OrderViewModel> FilterBy(params Expression<Func<Order, object>>[] navigationProperties); 

        void AddOrder(params OrderViewModel[] orderViewModels);
        void UpdateOrder(params OrderViewModel[] orderViewModels);
        void RemoveOrder(params OrderViewModel[] orderViewModels);

        void AddClient(params ClientViewModel[] clientViewModels);
        void UpdateClient(params ClientViewModel[] clientViewModels);
        void RemoveClient(params ClientViewModel[] clientViewModels);

        void AddManager(params ManagerViewModel[] managerViewModels);
        void UpdateManager(params ManagerViewModel[] managerViewModels);
        void RemoveManager(params ManagerViewModel[] managerViewModels);
    }
}
