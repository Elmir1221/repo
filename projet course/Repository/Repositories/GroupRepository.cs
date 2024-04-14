using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories.Data;
using Repository.Repositories.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext _context;
        public  GroupRepository()
        {
            _context = new AppDbContext();
        }
        public async Task Delete(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Group>> GetAll()
        {
            return await _context.Groups.ToListAsync();
        }

        public  Task<List<Group>> GetAllWithEducationId(Func<Group, bool> expression)
        {
            
        }

        public async Task<List<Group>> GetById(int Id)
        {
            return await _context.Groups.FirstOrDefault(m => m.Id = id);
        }

        public Task<List<Group>> GetEducationByName(Func<Group, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Task SavaChangeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Group>> Search(Func<Group, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Task SearchWithCapaCity()
        {
            throw new NotImplementedException();
        }

        public Task Uptate(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
