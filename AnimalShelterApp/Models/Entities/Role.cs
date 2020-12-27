using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class Role : BaseEntity
    {
        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

    }
}
