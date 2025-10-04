using ShoeInventoryApp.Models;

namespace ShoeInventoryApp.Services
{
    public class ShoeColorVariationService : IShoeColorVariationService
    {
        private readonly AppDbContext _context;

        public ShoeColorVariationService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ShoeColorVariation> GetAll()
        {
            return _context.ShoeColorVariations.ToList();
        }

        public ShoeColorVariation? GetById(int id)
        {
            return _context.ShoeColorVariations.Find(id);
        }

        public void Add(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Add(variation);
            _context.SaveChanges();
        }

        public void Update(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Update(variation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var variation = _context.ShoeColorVariations.Find(id);
            if (variation != null)
            {
                _context.ShoeColorVariations.Remove(variation);
                _context.SaveChanges();
            }
        }
    }
}
