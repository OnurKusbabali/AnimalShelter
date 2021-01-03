using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelterApp.Models;
using AnimalShelterApp.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace AnimalShelterApp.Pages.Animals
{
    [Authorize(Roles="Admin")] 
    public class EditModel : PageModel
    {
        public List<Shelter> Shelters { get; set; }
        private readonly DbContextAnimalShelter _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EditModel(UserManager<IdentityUser> userManager, DbContextAnimalShelter db, IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _db = db;
            _userManager = userManager;
        }
       
        public void OnGet(Guid Id)
        {
            Animal = _db.Animals.Include(x=>x.Shelter).Where(x => x.Id == Id).FirstOrDefault();

            Shelters = _db.Shelters.ToList();
        }

        public class InputModel
        {
            [Required]
            public string Name { get; set; }

            public Guid Id { get; set; }

            public string Description { get; set; }

            public IFormFile Image { set; get; }

            public Guid ShelterId { get; set; }
        }
        public Animal Animal { get; set; }
        public IActionResult OnPost([FromForm] InputModel _InputModel)
        {
            if (_InputModel.Name != null)
            {
                Animal = new Animal();
                Animal.Description = _InputModel.Description;
                Animal.Name = _InputModel.Name;
                Animal.SheltedId = _InputModel.ShelterId;
                if (_InputModel.Image != null)
                {
                    var uniqueFileName = GetUniqueFileName(_InputModel.Image.FileName);
                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    _InputModel.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    Animal.ImageUrl = filePath;
                    //to do : Save uniqueFileName  to your db table   
                }

                _db.Animals.Update(Animal);
                _db.SaveChanges();
                return Redirect("/Animals/Index");
            }
            return Page();
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
