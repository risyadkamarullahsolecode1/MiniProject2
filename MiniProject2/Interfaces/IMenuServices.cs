using MiniProject2.Models;

namespace MiniProject2.Interfaces
{
    public interface IMenuServices
    {
        void AddMenu(Menu menu);
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        void UpdateMenu(Menu menu);
        void DeleteMenu(int id);
        int AddRating(int id, int rating);
    }
}
