using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models.Cars
{
    public class Car
    {
        public long Id { get; set; }
        public string NumberPlate { get; set; }
        public int Seats { get; set; }
        public bool LuggageSpace { get; set; }
        public bool TechnicallyApproved { get; set; }

        public virtual long ModelId { get; set; }
        public virtual long ColorId { get; set; }
        public virtual long EngineId { get; set; }

        [JsonIgnore]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
