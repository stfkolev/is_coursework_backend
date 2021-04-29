using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Powertrain
    {
        public long Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Engine> Engines { get; set; }
    }
}
