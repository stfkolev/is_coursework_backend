using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACarBackend.Models
{
    /// <summary>
    /// Company Entity
    /// </summary>
    public class Company
    {
        public long Id {  get; set; }
        public string Name { get;set; }

        [JsonIgnore]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
