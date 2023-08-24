using CasgemMicroservices.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservices.Services.Cargo.DataAccessLayer.Context;
using CasgemMicroservices.Services.Cargo.DataAccessLayer.Repository;
using CasgemMicroservices.Services.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoDetailDal:GenericRepository<CargoDetail>,ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context) : base(context)
        {

        }
    }
}
