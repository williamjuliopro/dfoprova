using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private DatabaseContext db;

        public UserController(DatabaseContext _db)
        {
            db = _db;

        }

        //[HttpGet()]
        //public IActionResult Get(int? id = null)
        //{
        //    if (id != null)
        //        return Ok(db.User.Where(x => x.id == id).FirstOrDefault());
        //    else
        //        return Ok(db.User.ToList());
        //}


        [HttpGet("List")]
        public IActionResult List()
        {
            return Ok(db.User.ToList());
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(db.User.Where(x => x.id == id).FirstOrDefault());
        }

        [HttpPost("Create")]
        public IActionResult Create(User user)
        {
            db.User.Add(user);
            db.SaveChanges();

            return Ok(db.User.Where( x => x.Name == user.Name && x.Address == user.Address));
        }



        [HttpPut()]
        public IActionResult Update(User user)  
        {
            User userbd = db.User.Where(x => x.id == user.id).FirstOrDefault();
            if (userbd != null)
            {
                userbd.Name = user.Name;
                userbd.Age = user.Age;
                userbd.Address = user.Address;

                db.SaveChanges();
            }
            else
                NotFound("Usuário não encontrado");


            return Ok(userbd);
        }


        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            User user = db.User.Where(x => x.id == id).FirstOrDefault();
            if (user != null)
            {
                db.User.Remove(user);
            }
            else
                NotFound("Usuário não encontrado");


            return Ok("Usuário removido com sucesso");
        }

    }
}
