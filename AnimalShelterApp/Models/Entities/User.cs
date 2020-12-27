using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models.Entities
{
    public class User : BaseEntity
    {
        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(128)]
        public string Surname { get; set; }

        [EmailAddress(ErrorMessage ="Mail adresi doğru formatta değil")]
        public string Email { get; set; }

        public string Password { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        public string PhotoUrl { get; set; }
    }
}
