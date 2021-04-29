using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models
{
    public class Client
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UCN { get; set; }
        public string License { get; set; }

        public DateTime LicenseExpiryDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
