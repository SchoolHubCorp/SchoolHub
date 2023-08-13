using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Interface;
using webapi.Models;

namespace webapi.DataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUserController : Controller
    {
        private readonly DataContext _db;


        public GetUserController(DataContext db)
        {
            _db = db;
        }

        [HttpGet("getdb")]
        public async Task<List<User>> GetDb()
        {
            return await _db.User.OrderByDescending(x => x.Id).ToListAsync();
        }

        [HttpGet]
        private async Task<ActionResult> GetUser()
        {
            IEnumerable<User> objList = await _db.User.ToListAsync();
            return View(objList);
        }
    }
}
