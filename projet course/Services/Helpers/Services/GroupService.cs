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
    public class GroupService : IGroupService
    {
        private object _context;
        public GroupService()
        {
            _context = new AppDbContext();
        }

        public async Task DeleteAsync(int id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            var data = _context.Group.FirstOrDefault(m => m.id = id);
            if (data == null)
            {
                throw new NotFoundException("data not found");
            }
        }

        public async Task<List<Group>> GetAll()
        {
            return await _context.Group.ToListAsync();
        }

        public async Task<List<Group>> GetAllWithEducationId(Func<Group, bool> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Group>> GetById(int Id)
        {
            var data = _context.Group.FirstOrDefault(m => m.id = id)ToList();
        }

        public async Task<List<Group>> GetEducationByName(Func<Group, bool> expression)
        {
            throw new NotImplementedException();
        }

        public async Task SavaChangeAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Group>> Search(Func<Group, bool> expression)
        {
            throw new NotImplementedException();
        }

        public async Task SearchWithCapaCity()
        {
            throw new NotImplementedException();
        }

        public async Task Uptate(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
