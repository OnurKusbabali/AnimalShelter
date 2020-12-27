using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelterApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimalShelterApp.Pages.Animals
{
    public class IndexModel : PageModel
    {
        public List<Animal> Animals { get; set; }
        public void OnGet()
        {
        }
    }
}
