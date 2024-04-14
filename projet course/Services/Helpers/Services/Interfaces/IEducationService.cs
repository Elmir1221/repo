using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers.Services.Interfaces
{
    public interface IEducationService
    {
        Task<List<Education>> GetAllAsync();
        Task<List<Education>> GetByIdAsync(int id);
        Task<List<Education>> DeleteAsync(int id);
        Task<List<Education>> UpdateAsync(int Id);
        Task<List<Education>> SearchAsync(Func<Education, bool> expression);
        Task<List<Education>> GetAllWithGroupsAsync(Func<Education, bool> expression);
        Task<List<Education>> SorthWithCreateDateAsync(DateTime CreatedDate);
    }
}
