using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    /// <summary>
    /// Manufacturer
    /// </summary>
    public class Manufacturer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual long CountryId { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> CarModels { get; set; }

    }
}
