using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IBrandDal
    {
        void Add(Brand brand);
        List<Brand> GetAll();
    }
}