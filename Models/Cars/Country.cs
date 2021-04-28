using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{    
    /// <summary>
     /// Country Entity
     /// </summary>
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }
    }
}
