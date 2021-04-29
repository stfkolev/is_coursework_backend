using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Color
    {
        public long Id { get; set; }
        public string name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
