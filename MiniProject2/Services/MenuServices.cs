using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Services
{
    public class MenuServices:IMenuServices
    {
        private List<Menu> _menu = new List<Menu>();

        //Add menu
        public void AddMenu(Menu menu)
        {
            _menu.Add(menu);
        }
        //Get All Menu
        public List<Menu> GetAllMenus()
        {
            return _menu;
        }
        //Get MenuById
        public Menu GetMenuById(int id)
        {
            return _menu.FirstOrDefault(m => m.Id == id);
        }

        // Update
        public void UpdateMenu(Menu menu)
        {
            var daftarMenu = GetMenuById(menu.Id);
            if (daftarMenu != null)
            {
                return;
            }
            daftarMenu.Name = menu.Name;
            daftarMenu.Price = menu.Price;
            daftarMenu.Category = menu.Category;
            daftarMenu.CreatedDate = menu.CreatedDate;
            daftarMenu.Rating = menu.Rating;
            daftarMenu.IsAvailable = menu.IsAvailable;
        }

        // Delete
        public void DeleteMenu(int id)
        {
            var menu = GetMenuById(id);
            if (menu != null)
            {
                _menu.Remove(menu);
            }
        }

        public void AddRating(int id, int rating)
        {
            var menu = GetMenuById(id);
            if (menu != null)
            {
                menu.Rating = rating;
            }
        }
    }
}
