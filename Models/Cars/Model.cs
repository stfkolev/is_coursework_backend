using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Model
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual long ManufacturerId { get; set; }
        public virtual long CarTypeId { get; set; }


        public virtual ICollection<Car> Cars { get; set; }
    }
}
