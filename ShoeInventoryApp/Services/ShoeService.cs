using ShoeInventoryApp.Models;

namespace ShoeInventoryApp.Services
{
    public class ShoeService : IShoeService  // <-- Must implement the interface
    {
        private readonly AppDbContext _context;

        public ShoeService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shoe> GetAllShoes()
        {
            return _context.Shoes.ToList();
        }

        public Shoe GetShoeById(int id)
        {
            return _context.Shoes.Find(id);
        }

        public void AddShoe(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
            _context.SaveChanges();
        }

        public void UpdateShoe(Shoe shoe)
        {
            _context.Shoes.Update(shoe);
            _context.SaveChanges();
        }

        public void DeleteShoe(int id)
        {
            var shoe = _context.Shoes.Find(id);
            if (shoe != null)
            {
                _context.Shoes.Remove(shoe);
                _context.SaveChanges();
            }
        }
    }
}
