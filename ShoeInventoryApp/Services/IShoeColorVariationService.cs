using ShoeInventoryApp.Models;

namespace ShoeInventoryApp.Services
{
    public interface IShoeColorVariationService
    {
        IEnumerable<ShoeColorVariation> GetAll();
        ShoeColorVariation? GetById(int id);
        void Add(ShoeColorVariation variation);
        void Update(ShoeColorVariation variation);
        void Delete(int id);
    }
}
