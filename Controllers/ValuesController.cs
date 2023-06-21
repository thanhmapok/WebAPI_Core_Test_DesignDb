using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebAPI_Core_Test_DesignDb.Data;
using WebAPI_Core_Test_DesignDb.Models;

namespace WebAPI_Core_Test_DesignDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyDbContext db;
        public ValuesController(MyDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult listUser()
        {
            var list = db.Users.ToList();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public IActionResult getbyID(int id)
        {
            User userOnly = db.Users.Find(id);
            string wardOnly = db.Wards.SingleOrDefault(m => m.idWard == userOnly.idWard).NameWard;
            UserInfo thisUser = new UserInfo()
            {
                Name = userOnly.Name,
                Role = userOnly.Role,
                NameWard = wardOnly
            };
            return Ok(thisUser);
        }
        [HttpPost]
        public IActionResult Create(string name, string role, int idWard)
        {
            try
            {
                User newU = new User();
                newU.Name = name;
                newU.Role = role;
                newU.idWard = idWard;
                db.Users.Add(newU);
                db.SaveChanges();
                return Ok("Tạo thành công!!!");
            }catch (Exception)
            {
                return BadRequest("Thất bại!!!");
            }
            
        }
    }
}
