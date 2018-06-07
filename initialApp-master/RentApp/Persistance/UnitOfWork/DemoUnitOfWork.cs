using RentApp.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;
using Unity.Attributes;

namespace RentApp.Persistance.UnitOfWork
{
    public class DemoUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        [Dependency]
        public IServiceRepository Services { get; set; }
        public IBranchRepository Branches { get; set; }
        public IVehicleRepository Vehicles { get; set; }
        public ITypeOfVehicleRepository TypeOfVehicles { get; set; }
        public IRentRepository Rents { get; set; }
        public IAppUserRepository AppUsers { get; set;
        }
        public DemoUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}