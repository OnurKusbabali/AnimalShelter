using AnimalShelterApp.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models
{
    public class DbContextAnimalShelter : IdentityDbContext
    {
        public DbContextAnimalShelter(DbContextOptions<DbContextAnimalShelter> options) : base(options)
        {

        }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<Photo> Photos { get; set; }

        //public DbSet<Role> Roles { get; set; }

        public DbSet<Shelter> Shelters { get; set; }

        //public DbSet<User> Users { get; set; }

    }
}
