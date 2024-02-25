using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreatedBrandRequest brand);

        List<Brand> GetAll();
    }
}