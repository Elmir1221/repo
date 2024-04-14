using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories.Data;
using Services.Helpers.Exceptions;
using Services.Helpers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers.Services
{
    public class EducationService : IEducationService
    {
        private readonly AppDbContext _context;

        public EducationService()
        {
            _context = new AppDbContext();
        }
        public async Task<List<Education>> DeleteAsync(int id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            var data = _context.Educations.FirstOrDefault(m => m.id = id);
            if(data == null)
            {
                throw new NotFoundException("data not found");
            }
        }

        public Task<List<Education>> GetAllAsync()
        {
            return await _context.Educations.ToListAsync();
        }

        public async Task<List<Education>> GetAllWithGroupsAsync(Func<Education, bool> expression)
        {
            var educations = await _context.Educations.Include(m => m.Group).ToList();
            if (educations.Count == 0)
            {
                throw new NotFoundException("data not found");
            }
            return educations;
        }

        public async Task<List<Education>> GetByIdAsync(int id)
        {
            var data = _context.Educations.FirstOrDefault(m => m.id = id);
        }

        public async Task<List<Education>> SearchAsync(Func<Education, bool> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Education>> SorthWithCreateDateAsync(DateTime CreatedDate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Education>> UpdateAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
