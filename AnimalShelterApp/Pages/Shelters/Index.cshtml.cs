using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelterApp.Models;
using AnimalShelterApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
namespace AnimalShelterApp.Pages.Shelters
{
    public class IndexModel : PageModel
    {
        public List<Shelter> _shelters;
        private readonly DbContextAnimalShelter _db;
        public IndexModel(DbContextAnimalShelter db)
        {
            _db = db;
        }
        public void OnGet()
        {
            _shelters = _db.Shelters.ToList();
        }
    }
}
