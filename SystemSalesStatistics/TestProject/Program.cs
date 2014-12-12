using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObjectsLayer;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerViewModel m = new ManagerViewModel {ID = 5, Name = "dgdfgd"};
            Manager manager = m.Convert();

            Console.WriteLine(manager.ID + " " + manager.Name);
        }
    }
}
