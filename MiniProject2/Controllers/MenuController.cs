using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuServices _menuServices;

        public MenuController(IMenuServices menuServices)
        {
            _menuServices = menuServices;
        }
        /// <summary>
        /// You can search for Accounts here.
        /// </summary>

        /// <remarks>
        /// All the parameters in the request body can be null. 
        ///
        ///  You can search by using any of the parameters in the request.
        ///  
        ///  NOTE: You can only search by one parameter at a time
        ///  
        /// Sample request:
        ///
        ///     POST /Account
        ///     {
        ///        "userId": null,
        ///        "bankId": null,
        ///        "dateCreated": null
        ///     }
        ///     OR
        ///     
        ///     POST /Account
        ///     {
        ///        "userId": null,
        ///        "bankId": 000,
        ///        "dateCreated": null
        ///     } 
        /// </remarks>
        /// <param name="request"></param>
        /// <returns> This endpoint returns a list of Accounts.</returns>
       

        //Add Menu
        [HttpPost]
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
        [HttpGet("{id}")]
        public ActionResult GetMenuById(int id)
        {
            var menu = _menuServices.GetMenuById(id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpPut]
        public ActionResult UpdateMenu(Menu menu)
        {
            _menuServices.UpdateMenu(menu);
            return Ok(menu);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMenu(int id)
        {
            _menuServices.DeleteMenu(id);
            return Ok("Menu Telah Dihapus");
        }

        [HttpPost("{id}/{rating}")]
        public IActionResult AddRating(int id, int rating)
        {
            _menuServices.AddRating(id, rating);
            return Ok();
        }
    }
}
