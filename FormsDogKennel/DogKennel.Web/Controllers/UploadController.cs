using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DogKennel.Web.Models.DataAccessPostgreSqlProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DogKennel.Web.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(KennelOfDog));
                var kennel = (KennelOfDog)xs.Deserialize(stream);

                using (var db = new KennelOfDogDbContext())
                {
                    var dbs = new DbKennelOfDog()
                    {
                        Name = kennel.Name,
                        Address = kennel.Address,
                        Photo = kennel.Photo,
                    };

                    dbs.Dog = new Collection<DbDog>();
                    foreach (var dog in kennel.Dog)
                    {
                        dbs.Dog.Add(new DbDog()
                        {
                            Breed = dog.Breed,
                            Gender = dog.Gender,
                            DateOfBirth = dog.DateOfBirth,
                            CostInRubles = dog.CostInRubles
                        });
                    }

                    db.DogKennels.Add(dbs);
                    db.SaveChanges();
                }
                return View(kennel);
            }
        }

        public ActionResult Image(int id)
        {
            using (var db = new KennelOfDogDbContext())
            {
                return base.File(db.DogKennels.Find(id).Photo, "image/jpg");
            }
        }

        public ActionResult List()
        {
            List<DbKennelOfDog> list;
            using (var db = new KennelOfDogDbContext())
            {
                list = db.DogKennels.Include(s => s.Dog).ToList(); 
            }
            return View(list);
        }
    }
}
