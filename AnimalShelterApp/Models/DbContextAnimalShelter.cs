using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelterApp.Models
{
    public class DbContextAnimalShelter : DbContext
    {
        public DbContextAnimalShelter(DbContextOptions<DbContextAnimalShelter> options)
        {

        }
    }
}
