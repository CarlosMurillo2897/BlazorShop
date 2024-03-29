
using BlazorShop_Models.DTO;

namespace BlazorShop_Business.Repository.IRepository {
    public interface ICategoryRepository {
        public CategoryDTO Create(CategoryDTO objDTO);
        public CategoryDTO Update(CategoryDTO objDTO);
        public int Delete(int id);
        public CategoryDTO Get(int id);
        public IEnumerable<CategoryDTO> GetAll();
    }
}