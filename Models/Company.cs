using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
    }
}
