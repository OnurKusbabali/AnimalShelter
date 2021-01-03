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
 

namespace AnimalShelterApp.Pages.Shelters
{
    [Authorize()]
    public class CreateModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private Shelter Shelter { get; set; }
        private readonly DbContextAnimalShelter _db;
        public CreateModel(UserManager<IdentityUser> userManager, DbContextAnimalShelter db, IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _db = db;
            _userManager = userManager;
        }
        public void OnGet()
        {
            
        }
        
        public class InputModel
        {
            [Required]
            public string Name { get; set; }

            public string Description { get; set; }

            public IFormFile Image { set; get; }
        }

        
        public IActionResult OnPost([FromForm]InputModel _InputModel)
        {
            if (_InputModel.Name != null)
            {
                Shelter = new Shelter();
                Shelter.Id = Guid.NewGuid();
                Shelter.CreateDate = DateTime.Now;
                Shelter.Description = _InputModel.Description;
                Shelter.Name = _InputModel.Name;
                
                if (_InputModel.Image != null)
                {
                    var uniqueFileName = GetUniqueFileName(_InputModel.Image.FileName);
                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    _InputModel.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    Shelter.ImageUrl = filePath;
                    //to do : Save uniqueFileName  to your db table   
                }

                _db.Shelters.Add(Shelter);
                _db.SaveChanges();
                return Redirect("/Shelters/Index");
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
