using CatShopAPI.Contexts;
using CatShopAPI.Models;

namespace CatShopAPI.Repositories;

public class CatRepository : ICatRepository
{
    private readonly CatDbContext _context;

    public CatRepository(CatDbContext context)
    {
        _context = context;
    }
    
    public void Add(Cat newCat)
    {
        _context.Add(newCat);
        _context.SaveChanges();
    }

    public Cat? GetById(int id)
    {
        Cat? wantedCat = _context.Cats.FirstOrDefault(cat => cat.Id == id);
        return wantedCat;
    }

    public List<Cat?> GetAll()
    {
        return _context.Cats.ToList();
    }

    public void DeleteById(int id)
    {
        Cat? catToBeDeleted = _context.Cats.FirstOrDefault(cat => cat.Id == id);
        if (catToBeDeleted != null)
        {
            _context.Cats.Remove(catToBeDeleted);
            _context.SaveChanges();
        }
    }

    public void UpdateById(int id, Cat updatedCat)
    {
        Cat? catToBeUpdated = _context.Cats.FirstOrDefault(cat => cat.Id == id);
        if (catToBeUpdated != null)
        {
            catToBeUpdated.Id = updatedCat.Id;
            catToBeUpdated.Age = updatedCat.Age;
            catToBeUpdated.Name = updatedCat.Name;
            catToBeUpdated.FurColor = updatedCat.FurColor;
            catToBeUpdated.Price = updatedCat.Price;
            catToBeUpdated.IsAvailable = updatedCat.IsAvailable;
            catToBeUpdated.AvailableFrom = updatedCat.AvailableFrom;
            catToBeUpdated.SoldOn = updatedCat.SoldOn;
            _context.SaveChanges();
        }
    }
}