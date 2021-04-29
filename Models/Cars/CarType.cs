using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class CarType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Model> CarModels { get; set; }
    }
}
