using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories.Data;
using Repository.Repositories.İnterface;

namespace Repository.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;

        public EducationRepository()
        {
            _context = new AppDbContext();
        }
        public async Task<List<Education>> DeleteAsync(int Id)
        {
            _context.Remove(Id);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Education>> GetAllAsync()
        {
            return await _context.Educations.ToListAsync();
        }

        public async Task<List<Education>> GetAllWithGroupsAsync(Func<Education, bool> expression)
        {
            return await _context.Educations.Include(m => m.Group).ToListAsync();
        }

        public Task<List<Education>> GetByIdAsync(int id)
        {
            return _context.Educations.FirstOrDefault(m => m.Id = id);
        }

        public async Task<List<Education>> SearchAsync(Func<Education, bool> expression)
        {
            return await _context.Educations.Where(m => m.Name.ToLower().Trim().Contains());
        }

        public async Task<List<Education>> SorthWithCreateDateAsync(DateTime CreatedDate)
        {
            return await _context.Educations.ToListAsync();
        }

        public Task<List<Education>> UpdateAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
