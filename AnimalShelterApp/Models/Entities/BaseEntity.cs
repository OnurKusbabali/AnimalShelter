using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeleteDateTime { get; set; }

        public bool Deleted { get; set; } = false;
    }
}
