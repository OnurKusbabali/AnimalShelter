using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class Animal : BaseEntity
    {
        [MaxLength(128)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public DateTime BirthDate { get; set; }

        [MaxLength(128)]
        public string Description { get; set; }

        [ForeignKey("Shelter")]
        public Guid SheltedId { get; set; }

        public Shelter Shelter { get; set; }

        public string ImageUrl { get; set; }
    }
}
