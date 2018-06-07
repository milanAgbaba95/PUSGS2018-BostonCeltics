using RentApp.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Persistance.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IServiceRepository Services { get; set; }
         IBranchRepository Branches { get; set; }
         IVehicleRepository Vehicles { get; set; }
         ITypeOfVehicleRepository TypeOfVehicles { get; set; }
         IRentRepository Rents { get; set; }
         IAppUserRepository AppUsers { get; set; }
       
        int Complete();
    }
}
