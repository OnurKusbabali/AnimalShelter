
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class Photo : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        [ForeignKey("Animal")]
        public Guid AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}
