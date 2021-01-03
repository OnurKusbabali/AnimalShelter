using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelterApp.Models;
using AnimalShelterApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace AnimalShelterApp.Pages.Animals
{
    public class IndexModel : PageModel
    {
        public List<Animal> Animals { get; set; }
        public DbContextAnimalShelter _db{ get; set; }

        public IndexModel(DbContextAnimalShelter _db)
        {
            this._db = _db;
        }
        public void OnGet()
        {
            Animals = _db.Animals.Include(x=>x.Shelter).ToList();
        }
    }
}
