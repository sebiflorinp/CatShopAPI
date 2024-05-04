using CatShopAPI.Models;

namespace CatShopAPI.Repositories;

public interface ICatRepository
{
    public void Add(Cat newCat);

    public Cat? GetById(int id);

    public List<Cat?> GetAll();
    
    public void DeleteById(int id);

    public void UpdateById(int id, Cat updatedCat);
}