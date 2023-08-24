using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Domain.Entities
{
    public class Addresss
    {
        public int AddresssID { get; set; }
        public string UserID { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
    //Kullanıcı ıd sine göre o kullanıcya ait bilgiler alınacak
}
