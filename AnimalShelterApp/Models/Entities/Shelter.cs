using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class Shelter : BaseEntity
    {
        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
