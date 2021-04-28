using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Engine
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public int Displacement { get; set; }
        public int Power { get; set; }
        public int Torque { get; set; }
        public int Cyllinders { get; set; }

        public virtual long PowertrainId { get; set; }
        public virtual long FuelId { get; set; }
        public virtual long TransmissionId { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
