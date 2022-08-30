using Hello.Services.ProductAPI.DTOs;

namespace Hello.Services.ProductAPI.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<ResponseDto> Create(T entity);
        Task<ResponseDto> Update(T entity);
        Task<ResponseDto> Delete(int id);
    }
}
