using AutoMapper;
using BlazorShop_Business.Repository.IRepository;
using BlazorShop_DataAccess;
using BlazorShop_DataAccess.Data;
using BlazorShop_Models.DTO;

namespace BlazorShop_Business.Repository {
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public CategoryDTO Create(CategoryDTO objDTO)
        {
            var obj = _mapper.Map<CategoryDTO, Category>(objDTO);
            obj.CreatedDate = DateTime.Now;
            var addedObj = _db.Categories.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<Category, CategoryDTO>(addedObj.Entity);
        }

        public int Delete(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            if(obj != null) {
                _db.Categories.Remove(obj);
                return _db.SaveChanges();
            }
            return 0;
        }

        public CategoryDTO Get(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            if(obj != null) {
                return _mapper.Map<Category, CategoryDTO>(obj);
            }
            return new CategoryDTO();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(_db.Categories);
        }

        public CategoryDTO Update(CategoryDTO objDTO)
        {
            var objFromDB = _db.Categories.FirstOrDefault(u => u.Id == objDTO.Id);
            if(objFromDB != null) {
                objFromDB.Name = objDTO.Name;
                _db.Categories.Update(objFromDB);
                _db.SaveChanges();
                return _mapper.Map<Category, CategoryDTO>(objFromDB);
            }
            return objDTO;
        }
    }
}