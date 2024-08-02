using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuServices _menuServices;

        public MenuController(IMenuServices menuServices)
        {
            _menuServices = menuServices;
        }
        //Add Menu
        [HttpPost("AddMenu")]
        public IActionResult AddMenu(Menu menu)
        {
            _menuServices.AddMenu(menu);
            return Ok(menu);
        }

        //Get AllMenu
        [HttpGet]
        public List<Menu> GetAllMenu()
        {
            return _menuServices.GetAllMenus();
        }

        //Get MenuById
        [HttpGet("GetMenuById/{id}")]
        public ActionResult GetMenuById(int id)
        {
            var menu = _menuServices.GetMenuById(id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpPut("UpdateMenu")]
        public ActionResult UpdateMenu(Menu menu)
        {
            _menuServices.UpdateMenu(menu);
            return Ok(menu);
        }

        [HttpDelete("DeleteMenu/{id}")]
        public ActionResult DeleteMenu(int id)
        {
            _menuServices.DeleteMenu(id);
            return Ok("Menu Telah Dihapus");
        }

        [HttpPost("AddRating/{id}/{rating}")]
        public IActionResult AddRating(int id, int rating)
        {
            _menuServices.AddRating(id, rating);
            return Ok();
        }
    }
}
