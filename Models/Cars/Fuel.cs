using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Fuel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }
    }
}
