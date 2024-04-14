using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.İnterface
{
    public interface IGroupRepository
    {
        Task<List<Group>> GetAll();
        Task<List<Group>> GetById(int Id);
        Task<List<Group>> GetAllWithEducationId(Func<Group, bool> expression);
        Task<List<Group>> Search(Func<Group, bool> expression);
        Task Delete(int  id);
        Task Uptate(Group group);
        Task SavaChangeAsync();
        Task<List<Group>> GetEducationByName(Func<Group, bool> expression);
        Task SearchWithCapaCity();


    }
}
