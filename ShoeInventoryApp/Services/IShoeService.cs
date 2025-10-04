using ShoeInventoryApp.Models;

namespace ShoeInventoryApp.Services
{
    public interface IShoeService
    {
        IEnumerable<Shoe> GetAllShoes();
        Shoe GetShoeById(int id);
        void AddShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoe(int id);
    }
}
