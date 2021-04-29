using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarBackend.Models
{
    public class Rent
    {
        public long Id { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        
        public float Price { get; set; }

        public virtual long ClientId { get; set; }
        public virtual long CompanyId { get; set; }
        public virtual long CarId { get; set; }
    }
}
